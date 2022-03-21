using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
var builder = WebApplication.CreateBuilder(args);

// Dependency injection for database connections by applying connection strings to context classes.
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));

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
    pattern: "{controller=HelloWorld}/{action=WelcomeWithContext}/{id?}");

// Query the pattern directly:
// www.aumono.com?name=Talane&numTimes=16
// Query the route:
// www.aumono.com?/helloworld/welcome/4?name=Talane
// www.aumono.com?/helloworld/welcome/4?firstName=Aum&lastName=Ono
// www.aumono.com?/helloworld/welcome/Talane/4
// www.aumono.com?/helloworld/welcome/Aum/Ono/4

app.Run();
