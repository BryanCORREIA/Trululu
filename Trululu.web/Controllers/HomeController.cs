using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Trululu.web.Filters;
using Trululu.web.ViewModels;

namespace Trululu.web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Feedback()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Feedback(FeedbackViewModel feedbackViewModel)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Name", "from.website@example.com"));
            message.To.Add(new MailboxAddress("youremail@example.com"));
            message.Subject = $"[Contact from your website] { feedbackViewModel.Subject }";

            var builder = new BodyBuilder
            {
                HtmlBody = $"<div><span style='font-weight: bold'>De</span> : {feedbackViewModel.Name} </div><div><span style='font-weight: bold'>Mail</span> : {feedbackViewModel.Email}</div><div style='margin-top: 30px'>{feedbackViewModel.Message}</div>"
            };

            message.Body = builder.ToMessageBody();


            return View(feedbackViewModel);
        }
    }
}