using Microsoft.AspNetCore.Localization;
using System.Globalization;

public class SetCultureMiddleware
{
    RequestDelegate _next;

    public SetCultureMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var language = context?.Request?.RouteValues["abbreviatedLanguage"]?.ToString();

        if (!string.IsNullOrWhiteSpace(language))
        {
            try
            {
                CultureInfo.CurrentCulture = new CultureInfo(language);
                CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;
            }
            catch (Exception)
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
        }       

        await _next(context);
    }
}