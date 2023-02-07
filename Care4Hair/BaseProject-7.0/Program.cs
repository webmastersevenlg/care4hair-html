//using BaseProject.App_Resources;
//using BaseProject_7_0.App_start;
using BaseProject_7_0.App_Resources;
using BaseProject_7_0.App_start;
using BaseProject_7_0.XmlTools;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Localization;
using Shyjus.BrowserDetection;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSingleton< IBrowserDetector, BrowserDetector>();


builder.Services.AddLocalization(o => o.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
                new CultureInfo("en-US"),
                new CultureInfo("es-US"),
            };
    options.DefaultRequestCulture = new RequestCulture("en-US", "en-US");

    // You must explicitly state which cultures your application supports.
    // These are the cultures the app supports for formatting 
    // numbers, dates, etc.

    options.SupportedCultures = supportedCultures;

    // These are the cultures the app supports for UI strings, 
    // i.e. we have localized resources for.

    options.SupportedUICultures = supportedCultures;
});


var app = builder.Build();

Settings.Configuration = app.Services.GetService<IConfiguration>();
XmlReader.WebHostEnvironment = app.Services.GetService<IWebHostEnvironment>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseExceptionHandler(exceptionHandlerApp =>
    {
        exceptionHandlerApp.Run(async context =>
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            // using static System.Net.Mime.MediaTypeNames;
            context.Response.ContentType = Text.Plain;

            await context.Response.WriteAsync("An exception was thrown.");

            var exceptionHandlerPathFeature =
                context.Features.Get<IExceptionHandlerPathFeature>();

            Console.WriteLine(exceptionHandlerPathFeature.Error.Message);

            if (exceptionHandlerPathFeature?.Error is FileNotFoundException)
            {
                await context.Response.WriteAsync(" The file was not found.");
            }

            if (exceptionHandlerPathFeature?.Path == "/")
            {
                await context.Response.WriteAsync(" Page: Home.");
            }
        });
    });
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

RouteConfig.RegisterRoutes(app);
SpanishRouteConfig.RegisterRoutes(app);


app.Run();