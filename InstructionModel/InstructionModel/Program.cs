using LabActivtity2.Services;
using LabActivtity2.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. might remove later
// Add services to the container.
//builder.Services.AddSingleton<IMyFakeDataService, MyFakeDataService>();

//Database Connection Service
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.EnableSensitiveDataLogging(true);
    });
builder.Services.AddControllersWithViews();







var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


//var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
//context.Database.EnsureCreated();



var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.EnsureCreated();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
