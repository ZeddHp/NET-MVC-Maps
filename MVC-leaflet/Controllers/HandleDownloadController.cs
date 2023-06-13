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
                            string extractPath = Path.Combine(Directory.GetCurrentDirectory()+"/App_Data");
                            ZipFile.ExtractToDirectory(zipPath, extractPath);

                            // Cleanup: Delete the downloaded ZIP file
                            System.IO.File.Delete(zipPath);

                            // Return a success message
                            return Content("ZIP file extracted successfully.");
                        }
                    }
                    else
                    {
                        // Handle unsuccessful response
                        return Content("Error occurred while downloading the ZIP file.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                return Content("Error occurred while downloading or extracting the ZIP file.");
            }
        }
    }
}
