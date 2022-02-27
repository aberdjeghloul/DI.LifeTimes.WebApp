using DI.LifeTimes.WebApp.Models;
using DI.LifeTimes.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ISingletonOperation _singletonOperation;
        private readonly ITranscientOperation _transcientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly IMyService _myService;

        public HomeController(ILogger<HomeController> logger, ISingletonOperation singletonOperation, ITranscientOperation transcientOperation, IScopedOperation scopedOperation, IMyService myService)
        {
            _logger = logger;
            _singletonOperation = singletonOperation;
            _transcientOperation = transcientOperation;
            _scopedOperation = scopedOperation;
            _myService = myService;
        }

        public IActionResult Index()
        {
            return View();
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
    }
}
