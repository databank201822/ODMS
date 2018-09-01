using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using ODMS.Models;
using ODMS.Models.ViewModel;

namespace ODMS.ControllersApi
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SubRouteApiController : ApiController
    {
        private readonly ODMSEntitiesApi _dbapi = new ODMSEntitiesApi();

        [HttpGet]
        public IHttpActionResult GetSubRoute(int id)//id=psrid
        {
            DateTime currentdate=DateTime.Today;

            var subRoute = _dbapi.ApiGetSubRoute(id, currentdate).Select(x => new SubRouteApiVm
            {
                Subrouteid = x.route_id,
                SubrouteName = x.RouteName,
                Todayvisit = x.planned_visit_date==null?0:1
            });


            return Ok(subRoute);
        }
    }
}
