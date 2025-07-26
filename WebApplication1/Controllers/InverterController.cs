using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics; // For Debug.WriteLine
using WebApplication1.Services;
using WebApplication1.Helper;
using WebApplication1.Database;


namespace WebApplication1.Controllers
{
    public class InverterController : Controller
    {
        private readonly GoogleSheetService _googleSheetService;
        private readonly AppDbContext _context;
        private readonly ILogger<InverterController> _logger;

        public InverterController(GoogleSheetService googleSheetService, AppDbContext context, ILogger<InverterController> logger)
        {
            _googleSheetService = googleSheetService;
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> ImportFromGoogleSheet()
        {
            string sheetUrl = "https://docs.google.com/spreadsheets/d/1br1M7kFPzr3xbnW0VjEmOpsbkqyHx9ojfgqZYA6N_t4/gviz/tq?tqx=out:csv";

            // Fetch CSV
            string csvContent = await _googleSheetService.FetchCsvAsync(sheetUrl);

            // ✅ Console log the CSV content
            Console.WriteLine("---- CSV Content Start ----");
            Console.WriteLine(csvContent);
            Console.WriteLine("---- CSV Content End ----");

            Debug.WriteLine("CSV Length: " + csvContent.Length);
            _logger.LogInformation("CSV Content Length: {Length}", csvContent.Length);

            // Map to objects
            var dataList = InverterDataCsvMapper.ParseCsvString(csvContent);

            // ✅ Console log the first 3 mapped objects
            for (int i = 0; i < Math.Min(3, dataList.Count); i++)
            {
                var data = dataList[i];
                Console.WriteLine($"[#{i + 1}] InverterId: {data.InverterId}, Time: {data.Time}, Total_kWh: {data.Total_kWh}");
            }

            // Save to DB
            _context.InverterData.AddRange(dataList);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                Count = dataList.Count,
                Sample = dataList.Take(3)
            });
        }
    }
}
