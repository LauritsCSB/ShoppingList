using Microsoft.EntityFrameworkCore;
using ShoppingList.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext service
builder.Services.AddDbContext<ShoppingListContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=ShoppingList}/{action=Index}/{id?}");

app.Run();


//TODO
// Clien-Side og Server-Side validation vha JS eller Jquery
// User authentification og authorization, tillad brugere at logge ind og redigere deres egne indk�bslister
// Opdater UI med Bootstrap eller Tailwind
// Tilf�j s�ge/ filter funktion til indk�bslisten
// Tilf�j sorteringsfunktion
// Funktion til at eksportere indk�bsliste som CSV eller Excel fil
// Funktion til at importere indk�bsliste fra en fil