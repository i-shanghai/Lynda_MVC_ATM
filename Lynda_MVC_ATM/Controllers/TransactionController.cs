using Lynda_MVC_ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Lynda_MVC_ATM.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Transaction
        public ActionResult Index()
        {
            //List
            IEnumerable<Transaction> transaction = db.transactions.ToList();


            return View(transaction);
        }

        [ActionName("Create")]
        public ActionResult Deopist()
        {
            //获取当前登录用户的ATM Account
            string userId = User.Identity.GetUserId().ToString();

            CheckingAccount checkingAccount = db.checkingAccounts.Where(c => c.AplicationUserID == userId).FirstOrDefault();

            //CheckingAccount 卡号
            string checkingAccountNo = "";
            if (checkingAccount != null)
            {
                checkingAccountNo = checkingAccount.AccountNo;
            }
            ViewBag.currentATMAccountNo = checkingAccountNo;

            //CheckingAccount ID
            int checkingAccountId = 0;
            if (checkingAccount != null)
            {
                checkingAccountId = checkingAccount.id;
            }

            ViewBag.currentATMAccountID = checkingAccountId;

            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Deopist(Transaction entity)
        {
            if (ModelState.IsValid)
            {
                //Save
                db.transactions.Add(entity);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View(entity);
        }
    }
}