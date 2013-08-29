using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RadoService.Areas.admin.Controllers
{
    [Authorize(Users="rado")]    
    public class BasicAdminController : Controller
    {
       

    }
}
