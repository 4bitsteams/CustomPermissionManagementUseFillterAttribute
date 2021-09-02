using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomPermissionManagementUseFillterAttribute.Models
{
    public class AbcAuthorizeAttribute : ActionFilterAttribute
    {
        private String _right;
        public AbcAuthorizeAttribute(String _right)
        {
            this._right = _right;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var hasClaim = filterContext.HttpContext.User.Claims.Where(c => c.Type == StaticDefinedData.Rights);

            //List<string> rightList = new List<string>();
            //foreach (var item in hasClaim)
            //{
            //    rightList.Add(item.Value.ToString());
            //}
            ////var principal = this.HttpContext.User;
            ////if (principal == null) throw new Exception("User not found");
            ////var claims = principal.Claims.ToList();

            if (_right != "CAN_VIEW_USER_LIST1")
            {
                filterContext.Result = new RedirectResult("~/");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
