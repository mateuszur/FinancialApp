using FinancialApp.Infrastructure.Extensions;
using FinancialApp.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Rejestracja servisu dla DB. Dodanie metody rozszerzajacej
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

//Data seeders section
var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<FinancialAppUserRolseSeeder>();

await seeder.SeedUserRoles();

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
