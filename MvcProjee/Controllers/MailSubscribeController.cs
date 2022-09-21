using BusınessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjee.Controllers
{
    [AllowAnonymous]
    public class MailSubscribeController : Controller
    {
        SubscribeMailManager sm = new SubscribeMailManager();

        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }   
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail p)
        {
          
            sm.BLAdd(p);
            return PartialView();
        }


    }
}