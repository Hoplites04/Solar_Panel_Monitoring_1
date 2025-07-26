using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using WebApplication1.Models;

namespace WebApplication1.Helper
{
    public static class InverterDataCsvMapper
    {
        public static List<InverterData> ParseCsvString(string csvContent)
        {
            var result = new List<InverterData>();

            using (var reader = new StringReader(csvContent))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                TrimOptions = TrimOptions.Trim,
            }))
            {
                csv.Context.RegisterClassMap<InverterDataMap>();

                try
                {
                    result = new List<InverterData>(csv.GetRecords<InverterData>());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ CSVHelper error: {ex.Message}");
                }
            }

            return result;
        }
    }
}
