using BscScan.NetCore;
using BscScan.NetCore.Configuration;

var builder = WebApplication.CreateBuilder(args);

var bscScanConfiguration = new BscScanConfiguration();
builder.Configuration.GetSection(nameof(BscScanOptions)).Bind(bscScanConfiguration.BscScanOptions);
builder.Services.AddSingleton(bscScanConfiguration);
builder.Services.AddBscScan(bscScanConfiguration);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
