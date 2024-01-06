var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
//request pipeline
//authentication
//routing
//controllerviewlar
//authorization
//razor
//rest api

// url/controller/action/id?

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/xyz", () => "Erkin hoşgeldin");
// app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
