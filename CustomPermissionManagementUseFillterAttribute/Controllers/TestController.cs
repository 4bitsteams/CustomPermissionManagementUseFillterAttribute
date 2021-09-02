using CustomPermissionManagementUseFillterAttribute.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomPermissionManagementUseFillterAttribute.Controllers
{
    public class TestController : Controller
    {
        [AbcAuthorizeAttribute("CAN_VIEW_USER_LIST")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
