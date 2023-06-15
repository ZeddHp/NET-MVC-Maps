using MVC_leaflet.Interfaces;

namespace MVC_leaflet.Services
{
    public class DatabasePopulator : IDatabasePopulator
    {
        private readonly IDataService _dataService;

        public DatabasePopulator(IDataService dataService)
        {
            _dataService = dataService;
        }

        public void PopulateDatabase()
        {
            if (FileExists())
            {
                // Read data from the file in the App_Data folder
                string filePath = GetFilePath();
                string data = ReadDataFromFile(filePath);

                // Clean the data(remove extra symbols)
                string cleanedData = CleanData(data);

                _dataService.PopulateDatabase(cleanedData);
            }
            else
            {
                // TODO: add exception                 
            }
        }

        private bool FileExists()
        {
            string filePath = GetFilePath();
            return File.Exists(filePath);
        }

        private string GetFilePath()
        {
            string appDataPath = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
            string fileName = "AW_VIETU_CENTROIDI.csv";
            string filePath = Path.Combine(appDataPath, fileName);
            return filePath;
        }

        private string ReadDataFromFile(string filePath)
        {
            string data = File.ReadAllText(filePath);
            return data;
        }

        private string CleanData(string data)
        {
            string cleanedData = data.Replace("#", "");
            return cleanedData;
        }

    }

}
