using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_leaflet.Models;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVC_leaflet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DownloadAndProcessData()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DownloadAndProcessData(string url)
        {
            // Path to store the downloaded ZIP file
            //string zipFilePath = "path/to/file.zip";
            string zipFilePath = "MVC-leaflet/App_Data/aw_csv.zip";

            // Path to extract the contents of the ZIP file
            string extractionPath = "MVC-leaflet/App_Data";

            // Download the ZIP file
            //await DownloadFile(url, zipFilePath);

            // Extract the contents of the ZIP file
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);

            // Read and process the CSV file(s)
            //string[] csvFiles = Directory.GetFiles(extractionPath, "*.csv");

            string csvFile = "MVC-leaflet/App_Data/aw_csv.csv";
            ProcessCsvFile(csvFile);

            /*foreach (string csvFile in csvFiles)
            {
                // Process each CSV file and store data in DB
                ProcessCsvFile(csvFile);
            }*/

            // Clean up the downloaded ZIP file and extracted contents
            //System.IO.File.Delete(zipFilePath);
            //Directory.Delete(extractionPath, true);

            ViewBag.Message = "CSV data has been stored in the database.";
            return View();
        }

        private async Task DownloadFile(string url, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
                    {
                        using (Stream streamToWriteTo = System.IO.File.Open(filePath, FileMode.Create))
                        {
                            await streamToReadFrom.CopyToAsync(streamToWriteTo);
                        }
                    }
                }
            }
        }

        private void ProcessCsvFile(string csvFilePath)
        {
            // Read and process the CSV file here, and store the data in the database
            // Example: using a CSV parser library like CsvHelper
            // var reader = new CsvReader(new StreamReader(csvFilePath));
            // var records = reader.GetRecords<YourModelClass>();
            // foreach (var record in records)
            // {
            //     // Store the data in the database
            // }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
