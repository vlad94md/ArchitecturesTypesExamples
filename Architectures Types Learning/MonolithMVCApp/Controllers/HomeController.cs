using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonolithMVCApp.Models;

namespace MonolithMVCApp.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db = new MobileContext();

        public ActionResult Index()
        {
            var phones = db.Phones.ToList();
            return View(phones);
        }

        public ActionResult MakeOrder(int? id)
        {
            if (id == null)
                return HttpNotFound();

            Phone phone = db.Phones.Find(id);
            if (phone == null)
                return HttpNotFound();

            OrderViewModel orderModel = new OrderViewModel { PhoneId = phone.Id };
            return View(orderModel);
        }
        [HttpPost]
        public ActionResult MakeOrder(OrderViewModel orderModel)
        {
            if (ModelState.IsValid)
            {
                Phone phone = db.Phones.Find(orderModel.PhoneId);
                if (phone == null)
                    return HttpNotFound();
                decimal sum = phone.Price;

                // если сегодня первое число месяца, тогда скидка в 10%
                if (DateTime.Now.Day == 1)
                    sum = sum - sum * 0.1m;

                Order order = new Order
                {
                    PhoneId = phone.Id,
                    PhoneNumber = orderModel.PhoneNumber,
                    Address = orderModel.Address,
                    Date = DateTime.Now,
                    Sum = sum
                };
                db.Orders.Add(order);
                db.SaveChanges();
                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            return View(orderModel);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}