﻿using DesignPatterns.BusinessLayer.Abstract;
using DesignPatterns.EntityLayer.Concrete;
using DesignPatterns.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var value1 = _customerService.TGetById(model.SenderID);
            var value2 = _customerService.TGetById(model.ReceiverID);
            value1.CustomerBalance -= model.Amount;
            value2.CustomerBalance+=model.Amount;
            List<Customer> modifiedCustomers = new List<Customer>()
            {
                value1,
                value2
            };
            _customerService.TMultiUpdate(modifiedCustomers);
            return View();
        }
    }
}
