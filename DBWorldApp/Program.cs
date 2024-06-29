using DBWorldApp.Repositories;
using DBWorldApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<CsvService>();
builder.Services.AddSingleton<ExcelService>();
builder.Services.AddSingleton<IReceiptRepository, ReceiptRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Receipts}/{action=Index}/{id?}");

app.Run();
