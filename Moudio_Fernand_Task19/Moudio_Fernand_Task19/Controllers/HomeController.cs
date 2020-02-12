using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DbProvider;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moudio_Fernand_Task19.Models;

namespace Moudio_Fernand_Task19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var vm = new UsersAndAwardsViewModel();

            UsersBdDAO contextUsers = new UsersBdDAO();
            AwardsBdDAO contextAwards = new AwardsBdDAO();

            var listUsers = contextUsers.GetList();
            var listAwards = contextAwards.GetList();

            foreach (var user in listUsers)
            {
                vm.ListUsers.Add(user);
            }
            foreach (var award in listAwards)
            {
                vm.ListAwards.Add(award);
            }

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult PartialNewUser()
        {
            return PartialView("_CreateNewUser");
        }

        public ActionResult PartialAddAwardUser()
        {
            return PartialView("_AddAwardUser");
        }

        public ActionResult PartialDelAwardUser()
        {
            return PartialView("_DelAwardUser");
        }

        public ActionResult PartialDelAward()
        {
            return PartialView("_DelAward");
        }

        public ActionResult PartialDelUser()
        {
            return PartialView("_DelUser");
        }

        public ActionResult PartialEditAward()
        {
            return PartialView("_EditAward");
        }

        public ActionResult PartialEditUser()
        {
            return PartialView("_EditUser");
        }

        public ActionResult PartialNewAward()
        {
            return PartialView("_NewAward");
        }
    }
}
