using WebApplication1.Database;
using WebApplication1.Helper;
using WebApplication1.Models;
using WebApplication1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register AppDbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));  // SQLite connection string
builder.Services.AddHttpClient<GoogleSheetService>();

// Add services to the container.
// var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
// builder.WebHost.UseUrls($"http://*:{port}");
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var googleSheetService = scope.ServiceProvider.GetRequiredService<GoogleSheetService>();
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    try
    {
        string sheetUrl = "https://docs.google.com/spreadsheets/d/1br1M7kFPzr3xbnW0VjEmOpsbkqyHx9ojfgqZYA6N_t4/gviz/tq?tqx=out:csv";
        string csvContent = await googleSheetService.FetchCsvAsync(sheetUrl);

        Console.WriteLine("✅ CSV fetched. Parsing now...");

        var inverterList = InverterDataCsvMapper.ParseCsvString(csvContent);

        // Add InverterId if it's not part of CSV
        foreach (var item in inverterList)
        {
            item.InverterId = 1; // 🔧 or use dynamic value
        }

        // Save to SQLite
        db.InverterData.AddRange(inverterList);
        db.SaveChanges();

        Console.WriteLine($"✅ Imported {inverterList.Count} records to SQLite DB");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Error: {ex.Message}");
    }
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
