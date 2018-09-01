using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using ODMS.Models;

namespace ODMS.ControllersApi
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginApiController : ApiController
    {
        private readonly ODMSEntitiesApi _dbapi = new ODMSEntitiesApi();


        [HttpPost]
        public IHttpActionResult Checkuser(UserCheck user)
        {
            if (ModelState.IsValid)
            {
                var userinfo = _dbapi.ApiUserLogin(user.User, user.Pass).SingleOrDefault();

                DateTime todayDate = DateTime.Today;

               // var priviouslogin = _dbapi.tblm_UserLogin.Where(x => x.PSR_id == userinfo.PSRid && x.Date == todayDate);
               

                if (userinfo != null)
                {
                   

                        tblm_UserLogin tblmUserLogin = new tblm_UserLogin
                            {
                                Date = todayDate,
                                PSR_id = userinfo.PSRid,
                                Date_time_stamp = DateTime.Now,
                                current_lat = user.Lat,
                                current_lon = user.Lon,
                                imei = user.Imei
                                
                            };
                        _dbapi.tblm_UserLogin.Add(tblmUserLogin);
                        _dbapi.SaveChanges();
                    
                  
                    return Ok(userinfo);
                }
            }
            return Ok();
        }

    }


    public class UserCheck
    {
        [Required]
      public string User { get; set; }
        [Required]
      public string Pass { get; set; }

        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Imei { get; set; }
   

    }
}
