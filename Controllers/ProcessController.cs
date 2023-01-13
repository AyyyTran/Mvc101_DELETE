using System.Reflection;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mvc101.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        // public ActionResult Index()
        // {
        //     //can pass as viewbag, viewData and as a concrete class
        //     Process[] procs = Process.GetProcesses();
        //     ViewBag.Procs = procs;
        //     return View(procs);
        // }
        public ActionResult Index()
        {
            return View(Process.GetProcesses());
        }
        public ActionResult Display(int id)
        {
            return View(Process.GetProcessById(id));
        }

    }
}