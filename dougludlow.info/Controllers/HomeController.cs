using dougludlow.info.Models;
using Karbon.Cms.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace dougludlow.info.Controllers
{
    public class HomeController : KarbonController
    {
        public override ActionResult Index()
        {
            return base.Index();
        }

        [HttpPost]
        public ActionResult Index(MessageModel model)
        {
            if (ViewData.ModelState.IsValid)
            {
                using(var smtp = new SmtpClient())
                {
                    var message = new MailMessage();
                    message.To.Add("doug.ludlow@gmail.com");
                    message.Subject = "dougludlow.info: " + model.Name;
                    message.From = new MailAddress(model.Email);
                    message.Body = model.Message;
                    smtp.Send(message);
                }
            }

            return Redirect("/");
            //return base.Index();
        }
    }
}