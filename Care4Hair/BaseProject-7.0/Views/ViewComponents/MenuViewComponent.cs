using BaseProject_7_0.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject_7_0.Views.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public MenuViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync(string pageUrl, string spanishPageUrl)
        {
            MenuPartialViewModel menuPVM = new MenuPartialViewModel();
            menuPVM.Url = pageUrl;
            menuPVM.UrlSpanish = spanishPageUrl;
            return  View(menuPVM);
        }
    }
}
