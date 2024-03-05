using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wba.ViewComponentExample.Web.ViewModels;

namespace Wba.ViewComponentExample.Web.ViewComponents
{
    [ViewComponent(Name = "QuoteComponent")]
    public class ChuckNorrisViewComponent : ViewComponent
    {
        private const string QuoteUrl = "https://api.chucknorris.io/jokes/random";

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(QuoteUrl);
            var result = await response.Content.ReadAsStringAsync();
            var quoteComponentViewModel =
                JsonConvert.DeserializeObject<QuoteComponentViewModel>(result);
            return View(quoteComponentViewModel);
        }
    }
}
