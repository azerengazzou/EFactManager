using AutoMapper;
using EFactManagerAPI.Models.Dto.FieldsDTO;
using EFactManagerAPI.Models.Dto.ZonesContentDTO;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository.IRepository;
using EFactManagerAPI.Services.IServices;
using NPOI.SS.Formula.Functions;

namespace EFactManagerAPI.Services
{
    public class SplitFileErrorService : ISplitFileErrorService
    {

        private readonly IZoneRepository _zoneRepository;
        private readonly IZoneErrorRepository _zoneErrorRepository;
        private readonly IEfactFileContentRepository _factFileContentRepository;
        private readonly IMapper _mapper;
        public SplitFileErrorService(
                             IZoneRepository zoneRepository,
                            IEfactFileContentRepository factFileContentRepository,
                            IZoneErrorRepository zoneErrorRepository,
                            IMapper mapper)
        {
            _mapper = mapper;
            _zoneErrorRepository= zoneErrorRepository;
            _zoneRepository = zoneRepository;
            _factFileContentRepository = factFileContentRepository;
        }


        public async Task SplitHeaderContentAsync(List<RecordConfig> records, string headerToSpllt, int fileId, EfactFile filemodel)
        {
            List<RecordConfig> headerRecords = records.Where(r => r.recordPlacement.Equals("header")).ToList();

            int headerRecordLength = 0;
            int recordLength = 0;
            int startpos = 0;
            var header = headerToSpllt;
            var zoneContentList = new List<ZoneContent>();
            var errorsList = await _zoneErrorRepository.GetAllAsync();

            var headerStartRecord = headerRecords.FirstOrDefault(h => h.recordNumber.Equals("200"));
            var headerZones = await _zoneRepository.GetZonesByRecordIdAsync(headerStartRecord.id);

            try
            {
                foreach (RecordConfig headerRecordsConfig in headerRecords)

                    if (headerRecordsConfig.recordLength == headerStartRecord.recordLength)
                    {
                        headerRecordLength = headerStartRecord.recordLength;
                        var headerRecordSplit = header.Substring(0, headerRecordLength);
                        foreach (ZoneConfig zoneHeader in headerZones)
                        {
                            var zoneHeaderSplit = headerRecordSplit.Substring(startpos, zoneHeader.zonelength);
                            startpos = (startpos + zoneHeader.zonelength);

                            var contentModel = new ZoneContentCreateDTO
                            {
                                content = zoneHeaderSplit,
                                description = zoneHeader.description,
                            };

                            var field = new FieldCreateDTO
                            {
                                FileId = filemodel.id,
                                ZoneConfigId = zoneHeader.id,
                                isError=false,
                            };

                            contentModel.Field = field;
                            ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                            zoneContentList.Add(contentModeltoDB);

                        }
                        header = header.Substring(headerRecordLength, header.Length - headerRecordLength);
                        // header = header.Substring(headerRecordLength-1, 227);
                    }
                    else
                    {
                        var recordSplit = header.Substring(0, headerRecordsConfig.recordLength);
                        startpos = 0;
                        //var zoneHeaderSplit = recordSplit.Substring(0);
                        headerZones = await _zoneRepository.GetZonesByRecordIdAsync(headerRecordsConfig.id);
                        foreach (ZoneConfig zoneHeader in headerZones)
                        {
                            if (startpos + zoneHeader.zonelength > recordSplit.Length)
                            {
                                throw new Exception("Zone length is greater than record length.");
                            }
                            var zoneHeaderSplit = recordSplit.Substring(startpos, zoneHeader.zonelength);
                            startpos = (startpos + zoneHeader.zonelength);
                            var contentModel = new ZoneContentCreateDTO
                            {
                                content = zoneHeaderSplit,
                                description = zoneHeader.description,
                                Field = new FieldCreateDTO
                                {
                                    FileId = filemodel.id,
                                    ZoneConfigId = zoneHeader.id,
                                    isError = false,
                                }
                            };

                            ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                            zoneContentList.Add(contentModeltoDB);

                            if (zoneHeader.description.Contains("Code rejet"))
                            {
                                var errorDetected = errorsList.FirstOrDefault(err => err.codeError.Equals(zoneHeaderSplit));
                                if (errorDetected != null)
                                {
                                    contentModel.Field.isError = true;
                                    contentModel.Field.ZoneErrorId = errorDetected.id;
                                    contentModel.Field.ZoneError = errorDetected;
                                }
                            }

                        }

                        if (header.Length != 0 & headerRecords.Last() == headerRecordsConfig)
                        {
                            await _factFileContentRepository.CreateZoneContentsAsync(zoneContentList);
                            break;
                        }
                    }
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public async Task SplitBodyContentAsync(string filePath, List<RecordConfig> records, int fileId, EfactFile filemodel)
        {
            List<RecordConfig> bodyAndFooterRecords = records.Where(r => r.recordPlacement != "header").ToList();
            int recordLength = 0;

            var zoneContentList = new List<ZoneContent>();
            int numAttestation = 0;
            int numPrestation = 0;
            var errorsList = await _zoneErrorRepository.GetAllAsync();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string contentToSplit = await reader.ReadToEndAsync();
                    string header = contentToSplit.Substring(0, 677);
                    string restOfFile = contentToSplit.Substring(677);

                    try
                    {
                        while (restOfFile.Length > 0)
                        {
                            string recordStartNumber = restOfFile.Substring(0, 2);

                            var specificRec = bodyAndFooterRecords.FirstOrDefault(r => r.recordNumber == recordStartNumber);
                            if (specificRec != null)
                            {
                                switch (recordStartNumber)
                                {
                                    case "20":
                                        numAttestation++;
                                        numPrestation = 0;
                                        break;
                                    case "50":
                                        numPrestation++;
                                        break;
                                    case "51":
                                        break;
                                    case "80":
                                        numPrestation = 0;
                                        break;
                                    default:
                                        numAttestation = 0;
                                        numPrestation = 0;
                                        break;
                                }

                                var zones = await _zoneRepository.GetZonesByRecordIdAsync(specificRec.id);
                                recordLength = specificRec.recordLength;
                                var recordSplit = restOfFile.Substring(0, recordLength);
                                restOfFile = restOfFile.Substring(recordLength);
                                if (specificRec.Equals("50"))
                                {
                                    Console.WriteLine("50 detected");
                                }
                                if (zones != null)
                                {
                                    foreach (ZoneConfig zone in zones)
                                    {
                                        var start = zone.startPosition - 1;
                                        if (start + zone.zonelength > recordSplit.Length)
                                        {
                                            throw new Exception("Zone length is greater than record length.");
                                        }

                                        var zonesplit = recordSplit.Substring(start, zone.zonelength);

                                        var contentModel = new ZoneContentCreateDTO
                                        {
                                            content = zonesplit,
                                            description = zone.description,
                                            Field = new FieldCreateDTO
                                            {
                                                FileId = filemodel.id,
                                                ZoneConfigId = zone.id,
                                                numAttestation = numAttestation,
                                                numPrestation = numPrestation,
                                                isError = false
                                            }
                                        };

                                        if (zone.description.Contains("Code rejet"))
                                        {
                                            var errorDetected = errorsList.FirstOrDefault(err => err.codeError.Equals(zonesplit));
                                            if (errorDetected != null)
                                            {
                                                contentModel.Field.isError = true;
                                                contentModel.Field.ZoneErrorId = errorDetected.id;
                                                contentModel.Field.ZoneError = errorDetected;
                                            }
                                        }

                                        ZoneContent contentModeltoDB = _mapper.Map<ZoneContent>(contentModel);
                                        zoneContentList.Add(contentModeltoDB);
                                    }

                                }
                            }
                            else
                            {
                                restOfFile = restOfFile.Substring(800);
                            }
                        }
                        await _factFileContentRepository.CreateZoneContentsAsync(zoneContentList);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
