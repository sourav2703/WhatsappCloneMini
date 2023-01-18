using Asp.NetChatingWebsite.ChatRepo;
using Asp.NetChatingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetChatingWebsite.Controllers
{
    public class HomeController : Controller
    {
        public string UserKaName ;
        
        public ChatRepository _chatRepository = null;
        public HomeController(ChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }
        public IActionResult Index()
        {
            var id = _chatRepository.Index_Repository();
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public IActionResult chatingpage(string UserKaNaam )
        {
            UserKaName = UserKaNaam;
            ViewBag.namee = UserKaNaam;
            var data=  _chatRepository.chatingpage();
            return View(data);
        }
        [HttpPost]
        public IActionResult SentDataIntoDb(string UserMessage, string UserNameFromMethod)
        {
            UserKaName = UserNameFromMethod;
            var Id = _chatRepository.SentDataIntoDb(UserMessage, UserNameFromMethod);
            if (Id > 0)
            {
                return RedirectToAction(nameof(error2), new {UserKaName , Id} );
            }
            return View("chatingpage");
        }
        
        public IActionResult error2(string UserKaName , int Id)
        {
            ViewBag.id = Id;
            ViewBag.Namee = UserKaName;
            var AllMsg = _chatRepository.SentDataIntoDb();
            return View(AllMsg);
        }
       


       



    }
}
