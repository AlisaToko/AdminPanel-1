using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AdminPanel.Controllers
{

    public class NewsController : Controller
    {
        ApplicationContext _context;
        IWebHostEnvironment _environment;
        public NewsController(ApplicationContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        public async Task<IActionResult> Index()
        {
            var newList = await _context.News.Include(p => p.Pictures).ToListAsync();
            return View(newList);
        }

        public async Task<IActionResult> AllNews()
        {
            var newList = await _context.News.Include(p => p.Pictures).ToListAsync();
            return View(newList);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(string NewsName, string newsDescription, IFormFileCollection uploadedFiles)
        {
            var news = new News { Name = NewsName, Description = newsDescription };
            await _context.News.AddAsync(news);
            _context.SaveChanges();

            if (uploadedFiles != null)
            {
                foreach (var uploadedFile in uploadedFiles) {
                    //путь для хранения файла
                    var path = "/Pictures/" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                    {
                        //копируем изображения в папку wwroot
                        await uploadedFile.CopyToAsync(fileStream);
                    }

                    Picture pic = new Picture() { Name = uploadedFile.FileName, Path = path, News = news };
                    _context.Pictures.Add(pic);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
        

        [HttpPost]
        public async Task<IActionResult> Delete(int newsId)
        {
            
            var news = await _context.News.FindAsync(newsId);
            _context.Remove(news);
            _context.SaveChanges();
            return View();
        }







    }
}
