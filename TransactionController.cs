using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Retail_Bankingteam03.Models;
using System.Data.Entity.Core.Objects;

namespace Retail_Bankingteam03.Controllers
{
    
    public class TransactionController : Controller
    {
        // GET: Transaction
        DB03TMS155_1718Entities db = new DB03TMS155_1718Entities();
        public ActionResult searchdeposit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult searchdeposit(FormCollection f)
        {
            
            Session["Account_ID"] = f["txtAccountID"];
     

            return RedirectToAction("depositmoney");
        }
        public ActionResult depositmoney()
        {
            DB03TMS155_1718Entities db = new DB03TMS155_1718Entities();
            long id = Convert.ToInt64(Session["Account_ID"]);
            AccountDetails_3 abc = db.AccountDetails_3.Find(id);
            if (abc == null)
            {
                TempData["AlertMessage"] = 18;
                return RedirectToAction("searchdeposit");
            }
            else
            {
                return View(abc);
            }
            return View();
          }
        [HttpPost]
        public ActionResult depositmoney(FormCollection f)

        { 
            DB03TMS155_1718Entities db = new DB03TMS155_1718Entities();
        ObjectParameter o = new ObjectParameter("flag", 0);
        int amount = Convert.ToInt32(f["txtDeposit"]);
        AccountDetails_3 p2 = new AccountDetails_3();
        p2 = db.AccountDetails_3.Find(Convert.ToInt64(Session["Account_ID"]));
                db.sp_deposit1(Convert.ToInt64(Session["Account_ID"]), amount, o);
                if (Convert.ToInt32(o.Value) == 0)
                {
                    TempData["AlertMessage"] = 13;
                    return RedirectToAction("depositmoney");
                }
                else
                {
                    TempData["AlertMessage"] = 1;
                    return RedirectToAction("Viewaftertrans");
                } 
            return View();
        }
        public ActionResult searchwithdraw()
        {
            return View();
        }
        [HttpPost]
        public ActionResult searchwithdraw(FormCollection f)
        {
            Session["Account_ID"] = f["txtAccountID"];
            return RedirectToAction("withdrawmoney");
        }
        public ActionResult withdrawmoney()
        {
            DB03TMS155_1718Entities db = new DB03TMS155_1718Entities();
            long id = Convert.ToInt64(Session["Account_ID"]);
            AccountDetails_3 abc = db.AccountDetails_3.Find(id);
            return View(abc);
        }
        [HttpPost]
        public ActionResult withdrawmoney(FormCollection f,AccountDetails_3 c)
        {

            DB03TMS155_1718Entities db = new DB03TMS155_1718Entities();
            ObjectParameter o = new ObjectParameter("flag",0);
            int amount = Convert.ToInt32(f["txtWithdraw"]);
            AccountDetails_3 p2 = new AccountDetails_3();
            p2 = db.AccountDetails_3.Find(Convert.ToInt64(Session["Account_ID"]));
            if (p2 == null )
            {
                Response.Write("<script>alert('Account ID does not exist')</script>");
            }
            else
            {
                db.sp_withdraw(Convert.ToInt64(Session["Account_ID"]), amount, o);
                if (Convert.ToInt32(o.Value) == 0)
                {
                    TempData["AlertMessage"] = 10;
                    return RedirectToAction("withdrawmoney");
                }
                else
                {
                    TempData["AlertMessage"] = 1;
                    return RedirectToAction("Viewaftertrans");
                } }
            return View();
        }
        public ActionResult transfer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult transfer(TransactionDetails_3 c,FormCollection f)
        {
            Session["Account_ID"] = f["txtAccountID1"];
            long acc1 = Convert.ToInt64(f["txtAccountID1"]);
            long acc2 = Convert.ToInt64(f["txtAccountID2"]);
            int amount = Convert.ToInt32(f["txtAmount"]);
            AccountDetails_3 p1 = new AccountDetails_3();
            AccountDetails_3 p2 = new AccountDetails_3();
            p1 = db.AccountDetails_3.Find(acc1);
            p2 = db.AccountDetails_3.Find(acc2);
            if (p1 == null || p2 == null)
            {
                Response.Write("<script>alert('Account ID does not exist')</script>");
            }
            else
            {
                ObjectParameter o = new ObjectParameter("flag", 0);
                db.sp_transfer(acc1, acc2, amount, o);
                if (Convert.ToInt32(o.Value) == 0)
                {
                    TempData["AlertMessage"] = 1;
                    return RedirectToAction("transfer");
                }
                else
                {
                    TempData["AlertMessage"] = 2;
                    return RedirectToAction("Viewaftertrans");
                }
            }
            return View();
        }
       
        public ActionResult Viewaftertrans()
        {
            long id = Convert.ToInt64(Session["Account_ID"]);
            AccountDetails_3 o = new AccountDetails_3();
            o = db.AccountDetails_3.Find(id);
            return View(o);
           
        }

    }
}

