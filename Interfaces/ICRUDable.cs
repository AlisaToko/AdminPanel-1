using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Interfaces
{
    public interface ICRUDable
    {
        public Task<IActionResult> Index();
        [HttpPost]
        public Task<IActionResult> Create(string name, string description, IFormFileCollection uploadedFiles);
        public Task<IActionResult> Create();
        [HttpPost]
        public Task<IActionResult> Delete(int id);
        public Task<IActionResult> Edit(string name, string description);
    }
}
