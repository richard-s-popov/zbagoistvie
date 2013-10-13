using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZbagoistvieWithDelivery.Core;

namespace ZbagoistvieWithDelivery.Controllers
{
    public class Home1Controller : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Fail()
        {
            return View();
        }

        public ActionResult Order(int id)
        {
            if (id < 1 || id > 3)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public ActionResult OrderFinish(int id, string firstName, string subscriberEmail, string phone, string address)
        {
            var em = new EmailMessage
            {
                DisplayNameFrom = "ZbagoistvieWithDelivery",
                From = "u@rbprofit.ru",
                Message = string.Format("ФИО: {0}<br/>" +
                                        "Email: {1}<br/>" +
                                        "Тел.: {2}<br/>" +
                                        "Адрес: {3}<br/>", firstName, subscriberEmail, phone, address),
                To = "u@molchunov.com"
            };

            switch (id)
            {
                case 1:
                    em.Subject = "1 упаковка";
                    EmailService.SendMessage(
                        em,
                        "u@rbprofit.ru",
                        "123456aaa111",
                        "smtp.yandex.ru",
                        587,
                        true);

                    return Redirect("http://glopart.ru/buy/27158");
                    break;
                case 2:
                    em.Subject = "5 упаковок";
                    EmailService.SendMessage(
                        em,
                        "u@rbprofit.ru",
                        "123456aaa111",
                        "smtp.yandex.ru",
                        587,
                        true);

                    return Redirect("http://glopart.ru/buy/27159");
                    break;
                case 3:
                    em.Subject = "10 упаковок";
                    EmailService.SendMessage(
                        em,
                        "u@rbprofit.ru",
                        "123456aaa111",
                        "smtp.yandex.ru",
                        587,
                        true);

                    return Redirect("http://glopart.ru/buy/27161");
                    break;
                default:
                    return RedirectToAction("Index");
                    break;
            }
        }
    }
}
