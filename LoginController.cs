using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retail_Bankingteam03.Models;
using System.Data.Entity.Core.Objects;

namespace Retail_Bankingteam03.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginDetails_3 l)
        {
            if(ModelState.IsValid)
            {
                DB03TMS155_1718Entities db = new DB03TMS155_1718Entities();
                ObjectParameter or = new ObjectParameter("LoginID_3", 0);
                db.sp_LoginDetails_3(or, l.UserName_3, l.UserPassword_3);
                if (Convert.ToInt32(or.Value) > 0)
                {
                    ObjectParameter tt = new ObjectParameter("UserRole_3",typeof(string));
                    db.sp_LoginDetails_003(l.UserName_3, tt);
                    string r = tt.Value.ToString();
                    if (r == "CAE")
                    {
                        return RedirectToAction("CreateCustomer","Customer");
                    }
                    else

                    {
                        return RedirectToAction("CreateAccount","Account");
                    }
                }
                else
                {
                    Response.Write("<script>alert('invalid credentials')</script>");
                }

                ModelState.Clear();
            }
            
            return View();
        }
    

    }
}
