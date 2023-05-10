namespace EFactManagerAPI.Services.IServices
{
    public interface IBackUpFileService
    {
        string BackUpFileCreation(IFormFile file);
        string createDateForFileUse();
        bool DirectoryCreation(string directoryPath);
    }
}
