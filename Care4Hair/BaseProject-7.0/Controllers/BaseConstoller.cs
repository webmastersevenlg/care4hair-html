using BaseProject_7_0.Models.BaseModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

public class BaseController : Controller
{
    protected ViewResult BaseIndex(object model)
    {
        string view = "~/Views/BaseIndex/BaseIndexSkin.cshtml";
        return View(view, model);
    }

    protected ViewResult Skin(BasePageViewModel model)
    {
        string view = model.SkinName;
        if (view == null)
        {
            // throw new HttpException(404, "Skin Name is null");
        }
        return View(view, model);
    }
}
