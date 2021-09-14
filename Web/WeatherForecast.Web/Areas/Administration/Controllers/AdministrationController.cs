namespace WeatherForecast.Web.Areas.Administration.Controllers
{
    using WeatherForecast.Common;
    using WeatherForecast.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
