using Microsoft.AspNetCore.Mvc;
using Wba.ViewComponentExample.Web.ViewModels;

namespace Wba.ViewComponentExample.Web.ViewComponents
{
    [ViewComponent(Name = "DisclaimerComponent")]
    public class DisclaimerViewComponent : ViewComponent
    {
        public string DisclaimerMessage { get; set; }

        public IViewComponentResult Invoke()
        {
            DisclaimerMessage = $"Please do not take contents on this site all too serious!{DateTime.Now.ToShortDateString()}";
            DisclaimerComponentViewModel disclaimerComponentViewModel
                = new DisclaimerComponentViewModel
                {
                    Message = DisclaimerMessage
                };
            return View(disclaimerComponentViewModel);
        }
    }
}
