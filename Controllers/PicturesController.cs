using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class PicturesController : Controller
    {
        public async Task<IActionResult> Index()
        {

            return View();
        }

        /*
        ApplicationContext _context;
        IWebHostEnvironment _environment;
        public PicturesController(ApplicationContext context, IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        public async Task<IActionResult> Index()
        {
            
            return View();
        }


        public async Task<IActionResult> Create(string PicturesName, IFormFileCollection uploadedFiles)
        {
            var pictures = new Picture { Name = PicturesName };
            await _context.Pictures.AddAsync(pictures);
            _context.SaveChanges();

            if (uploadedFiles != null)
            {
                foreach (var uploadedFile in uploadedFiles)
                {
                    //путь для хранения файла
                    var path = "/Pictures/" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                    {
                        //копируем изображения в папку wwroot
                        await uploadedFile.CopyToAsync(fileStream);
                    }

                    Picture pic = new Picture() { Name = uploadedFile.FileName, Path = path };
                    _context.Pictures.Add(pic);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
*/


    }
}