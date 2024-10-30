using FinancialApp.Infrastructure.Extensions;
using FinancialApp.Infrastructure.Seeders;
using FinancialApp.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

//Rejestracja servisu dla DB. Dodanie metody rozszerzajacej
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

//Data seeders section

//Defoult Roles Seeder
var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<FinancialAppUserRolseSeeder>();

await seeder.SeedUserRoles();

//Assign super admin role to first user
var scopeDefaultUser = app.Services.CreateScope();
var seederDefaultUSer = scopeDefaultUser.ServiceProvider.GetRequiredService<FinancialAppDefaultUserSeeder>();

await seederDefaultUSer.SeedUserRoles();

//Default  Expense and Revenue Categories seeder
var scopeDefaultExpenseCategories = app.Services.CreateScope();
var seederDefaultExpenseCategories = scopeDefaultExpenseCategories.ServiceProvider.GetRequiredService<FinancialAppDefaultExpenseAndRevenueCategoriesSeeder>();

await seederDefaultExpenseCategories.SeedDefaultExpenseCategories();


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


app.MapRazorPages();

app.Run();
