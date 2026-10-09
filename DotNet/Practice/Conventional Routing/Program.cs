using Conventional_Routing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();


// Conventional routing
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "defualt",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );

    //endpoints.MapControllerRoute(
    //    name: "Student",
    //    pattern: "AllStudent/{controller=Student}/{action=Index}/{id?}"
    //    );

    endpoints.MapControllerRoute(
       name: "Student", // ae khane je kono name dea jabe
       pattern: "CreateStudent/{controller=Student}/{action=Create}/{id?}"
       );

    endpoints.MapControllerRoute(
       name: "Student",
       pattern: "EditStudent/{controller=Student}/{action=Edit}/{id?}"
       );

    //endpoints.MapControllerRoute(
    //   name: "Student",
    //   pattern: "DeleteStudent/{controller=Student}/{action=Delete}/{id?}"
    //   );
});

app.MapRazorPages()
   .WithStaticAssets();

app.Run();
