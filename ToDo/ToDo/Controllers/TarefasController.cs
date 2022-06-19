using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDo.Data;

namespace ToDo.Controllers
{
    public class TarefasController : Controller
    {

        private readonly AppCont _appCont;

        public IEnumerable<object> Tarefas { get; private set; }

        public TarefasController(AppCont appCont)
        {
            _appCont = appCont;
        }



        public IActionResult Index()
        {
            var allTasks = _appCont.Tarefas.ToList();
            return View(allTasks);
        }


        public async Task<IActionResult> Details(int? id)
        {
          if(id == null)
            {
                return NotFound(); 
            }

          var tarefas = await _appCont.Tarefas
                .FirstOrDefaultAsync(L => L.Id == id);
            if(tarefas == null)
            {
                return NotFound();
            }
            return View(tarefas); 



        }


    }
}











