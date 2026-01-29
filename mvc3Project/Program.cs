using Microsoft.EntityFrameworkCore;
using mvc3Project.DATA;

var builder = WebApplication.CreateBuilder(args);




var connectionString = builder.Configuration.GetConnectionString("constring");
builder.Services.AddDbContext<ApplicationDBContext>(options =>
     options.UseSqlServer(connectionString));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
    pattern: "{controller=Register}/{action=Create}/{id?}")
    .WithStaticAssets();


app.Run();
