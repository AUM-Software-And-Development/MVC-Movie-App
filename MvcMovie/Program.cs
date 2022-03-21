var builder = WebApplication.CreateBuilder(args);

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
    pattern: "{controller=HelloWorld}/{action=Welcome}/{id?}");

// helloworld/welcome/4?name=Talane
// helloworld/welcome/4?firstName=Aum&lastName=Ono
// helloworld/welcome/Talane/4
// helloworld/welcome/Aum/Ono/4

app.Run();
