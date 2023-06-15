using Microsoft.AspNetCore.Mvc;
using System.IO.Compression;

namespace MVC_Location_Seach.Controllers
{
    public class HandleDownloadController : Controller
    {
        private readonly HttpClient _httpClient;

        public HandleDownloadController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> DownloadData()
        {
            try
            {
                string filename = Guid.NewGuid().ToString("N") + ".zip";
                string downloadUrl = "https://data.gov.lv/dati/dataset/0c5e1a3b-0097-45a9-afa9-7f7262f3f623/resource/1d3cbdf2-ee7d-4743-90c7-97d38824d0bf/download/aw_csv.zip";

                using (var response = await _httpClient.GetAsync(downloadUrl))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            // Save the downloaded ZIP file
                            string zipPath = Path.Combine(Directory.GetCurrentDirectory(), filename);
                            using (var fileStream = new FileStream(zipPath, FileMode.Create))
                            {
                                await stream.CopyToAsync(fileStream);
                            }

                            // Extract the ZIP file
                            string extractPath = Path.Combine(Directory.GetCurrentDirectory() + "/App_Data");
                            ZipFile.ExtractToDirectory(zipPath, extractPath);

                            System.IO.File.Delete(zipPath);

                            // TODO: Add code to read the CSV file and insert data into the database
                            return LocalRedirectPermanent("/Places");
                        }
                    }
                    else
                    {
                        string zipPath = Path.Combine(Directory.GetCurrentDirectory(), filename);
                        System.IO.File.Delete(zipPath);
                        // Handle unsuccessful response
                        return LocalRedirectPermanent("/Places");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                return LocalRedirectPermanent("/Places");
            }
        }
    }
}
