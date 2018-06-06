using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CareIn.Platform.Controllers
{
    public class NurseController : ApiController
    {
        [HttpGet]
        [Route("api/GrupoByID")]
        public int GrupoByID(int GruCod)
        {
            return 1;
        }
    }
}
