using Microsoft.EntityFrameworkCore;
using MVCmicrosoft.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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






// ✅ Default Conventional Routing
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

// ✅ Custom Named Route for SEO-Friendly Blog URLs
//app.MapControllerRoute(
//    name: "blog",
//    pattern: "blog/{year}/{month}/{title}",
//    defaults: new { controller = "Blog", action = "Post" });

// ✅ Admin Panel Route (Separate Area)
//app.MapControllerRoute(
//    name: "admin",
//    pattern: "admin/{controller=Dashboard}/{action=Index}/{id?}");

// ✅ Attribute Routing (Defined Inside Controllers)
//app.MapControllers(); // This enables controllers using [Route] attributes

// ✅ Catch-All Route (404 Handling)





//Routes are evaluated top to bottom
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "catchall",
    pattern: "{*url}",
    defaults: new { controller = "Error", action = "NotFound" });

app.Run();
