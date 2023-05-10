using EFactManagerAPI.Services.IServices;

namespace EFactManagerAPI.Services
{
    public class BackUpFileService : IBackUpFileService
    {
        //Sauvegarde d'un fichier conforme sur le disque "serveur"
        public string BackUpFileCreation(IFormFile file)
        {
            try
            {
                string dateTimeWithoutSpaces = createDateForFileUse();
                string timer = DateTime.Now.Microsecond.ToString();
                string filePath = Path.Combine(@"E:\CorilusFormation_23\", "GestionFichier_Facturation_Corilus", "backfiles", dateTimeWithoutSpaces + timer + file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyToAsync(stream);
                }
                return filePath;
            }
            catch (Exception e)
            {
                Console.WriteLine("Problème de création fichier: " + e.ToString());
                throw;
            }
        }

        public string createDateForFileUse()
        {
            DateTime dateTime = DateTime.Now;
            string formattedDateTime = dateTime.ToString("MM-dd-yyyy hh-mm-ss tt"); // example formatted string
            string dateTimeWithoutSpaces = formattedDateTime.Replace(" ", ""); // remove spaces
            return dateTimeWithoutSpaces;
        }

        public bool DirectoryCreation(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            { Directory.CreateDirectory(directoryPath); }
            else
            { return false; }
            return true;
        }
    }
}
