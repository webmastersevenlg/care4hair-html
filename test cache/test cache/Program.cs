using Microsoft.AspNetCore.OutputCaching;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDonutOutputCaching();
builder.Services.AddOutputCache(options =>
{
    //options.AddBasePolicy(builder =>
    //    builder.Expire(TimeSpan.FromSeconds(5)));
});

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}



app.UseRouting();

//app.UseDonutOutputCaching();

app.UseOutputCache();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
