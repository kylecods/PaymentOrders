using PaymentOrders.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentOrders
{
    public class PaymentOrderController : Controller
    {
        public ActionResult Index()
        {
            ServiceClient serviceClient = new ServiceClient();
            List<PaymentOrder> paymentOrderList = serviceClient.GetData().ToList();
            return View(paymentOrderList);
        }

        public ActionResult Table()
        {
            ServiceClient serviceClient = new ServiceClient();
            List<PaymentOrder> paymentOrderList = serviceClient.GetData().ToList();
            return Json(new { data = paymentOrderList }, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PaymentOrder paymentOrder)
        {
            ServiceClient serviceClient = new ServiceClient();
            serviceClient.AddPaymentOrder(paymentOrder);
            return RedirectToAction(nameof(Index));
            //return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ServiceClient serviceClient = new ServiceClient();
            var paymentOrder = serviceClient.FindPaymentOrder(id);
            return View(paymentOrder);
        }

        [HttpPost]
        public ActionResult Edit(PaymentOrder paymentOrder)
        {
            ServiceClient serviceClient = new ServiceClient();
            serviceClient.EditPaymentOrder(paymentOrder);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            //ServiceClient o = new ServiceClient();
            //var paymentOrder = o.GetById(id);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(PaymentOrder paymentOrder)
        {
            //ServiceClient o = new ServiceClient();
            //o.Delete(id);

            //if(false)
            //{
            //    return View(paymentOrder);
            //}
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Details(int? id)
        {
            ServiceClient serviceClient = new ServiceClient();
            var paymentOrder = serviceClient.FindPaymentOrder(id);
            return View(paymentOrder);
        }
    }
}