namespace SystemTask.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using SystemTask.Data.Models.ViewModel;
    using SystemTask.Services.Data.Tehnical;

    public class TehnicalController : Controller
    {
        private readonly ITehnicalService tehnicalService;
      

        public TehnicalController(ITehnicalService tehnicalService)
        {
            this.tehnicalService = tehnicalService;
        }

        public IActionResult CreateTehnical()
        {
            var viewModel = new CreateTehnicalViewModel();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTehnical(CreateTehnicalViewModel model)
        {
            await this.tehnicalService.Create(model);
            return this.RedirectToAction("All");
        }

        public IActionResult All(int id = 1)
        {

            if (id <= 0)
            {
                return this.NotFound();
            }

            var viewModel = new AllListViewModel
            {
                Tehnicals = this.tehnicalService.GetAllTehnical<AllViewModel>(id),
                TehnicalBlocks = this.tehnicalService.GetAllBlocks<TehnicalBloksInputModel>(id),
                TehnicalEmployees = this.tehnicalService.GetAllEmployees<TehnicalEmployeesInputModel>(id),
                TehnicalSystems = this.tehnicalService.GetAllSystems<TehnicalSystemInputModel>(id),
            };

            return this.View(viewModel);
        }

    }
}
