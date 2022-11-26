using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Interfaces
{
    public interface IPicturesCRUDable
    {
        public Task<IActionResult> Index();
        [HttpPost]
        //добавление элементов для главнйо страницы , включая медиафайлы
        public Task<IActionResult> Create(string NewsName, string newsDescription, IFormFileCollection uploadedFiles);
        public Task<IActionResult> Create();
        [HttpPost]
        //Удаление
        public Task<IActionResult> Delete(int id);
        public Task<IActionResult> SetMainPictire(int IsMain);
    }
}
