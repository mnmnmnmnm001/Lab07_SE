using Microsoft.EntityFrameworkCore;
using SchoolAppCoreMVC.Models;
//using SchoolAppCoreRazor.Models; the pdf have this line, the instructor just copy and forgot to replace it

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SchoolContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDBConnectionString")));
var app = builder.Build(); //need to be after adding SchoolContext service, otherwise it will throw an error that SchoolContext is not found

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();