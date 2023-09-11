using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Demo_Project.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        public IActionResult Index()
        {
            var value = customerManager.GetCustomersListWithJob();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddCustomer() 
        {
            JobManager jobManager = new JobManager(new EfJobDal());
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value=x.JobID.ToString()
                                          }).ToList();
            ViewBag.v = values;
            return View();  
        
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            CustomerValidatior validationRules = new CustomerValidatior();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                customerManager.TInsert(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetById(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id) 
        {
            var value = customerManager.TGetById(id);
            JobManager jobManager = new JobManager(new EfJobDal());
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
            
           
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p) 
        {
            customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
