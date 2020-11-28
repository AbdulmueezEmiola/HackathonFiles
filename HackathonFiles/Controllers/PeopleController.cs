using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonFiles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonFiles.Controllers
{
    public class PeopleController : Controller
    {
        Person person = new Person
        {
            Name = "Emiola Abdulmueez Opeyemi",
            PhoneNumber = "+79515481967",
            Address = "Abdulmueez street, voronezh",
            vkLink = new Uri("http://vk.com"),
            fbLink = new Uri("http://facebook.com"),
            City = "Moscow",
            Email = "emiolaabdulmueez@gmail.com",
            INN = 12324356576,
            Kpp = 9876543,
            lawEntities = 1,
            Ip = 7,
            HashTags = new string[]{"mueez","abdul","Emiola"}
        };
        public IActionResult Index()
        {
            return View(person);
        }
    }
}