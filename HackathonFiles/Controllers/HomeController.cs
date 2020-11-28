using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HackathonFiles.Models;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using Firebase.Database;
using Firebase.Database.Query;
using HackathonFiles.Servics;
using Firebase.Storage;
namespace HackathonFiles.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            /*var userId = "12345";
            var currentLoginTime = DateTime.UtcNow.ToString("MM/dd/yyyy  HH:mm:ss");
            var ImageData = new ImageData() { TimeStampUtc = currentLoginTime };
            var result = await firebaseClient.Child("Users/" + userId + "/Logins").PostAsync(ImageData);
            ViewBag.CurrentUser = userId;
            ViewBag.Login = currentLoginTime;*/
            return View("ModelTrain");
        }
        private async Task UploadFile(IFormFile file,string folder)
        {
            var firebaseClient = new FirebaseStorage("hackathontest-e8d57.appspot.com");
            string fileName = file.FileName;
            var filePath = Path.GetTempFileName();
            using (var fs = System.IO.File.Create(filePath))
            {
                await file.CopyToAsync(fs);
                fs.Position = 0;
                var task = firebaseClient.Child(Guid.NewGuid().ToString()).PutAsync(fs);
                var downloadUrl = await task;
            }
        }
        public async Task<IActionResult> FileUpload(IFormFile file)
        {
            await UploadFile(file, "Users/image/");            
            return View("Index");
        }
        public async Task<IActionResult> ModelTrain(string uri)
        {
            var firebaseClient = new FirebaseClient("https://hackathontest-e8d57.firebaseio.com/");
            Url url = new Url { uris = uri.Split(';') };
            var result =await firebaseClient.Child("Url").PostAsync(url);
            return View("FileUpload");
        }
    }
}
