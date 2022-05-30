namespace SystemTask.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SystemTask.Data.Models.ViewModel;
    using SystemTask.Services.Data.Block;
    using SystemTask.Services.Data.Tehnical;

    public class TehnicalController : Controller
    {
        private readonly ITehnicalService tehnicalService;
        private readonly IBlockService blockService;

        public TehnicalController(ITehnicalService tehnicalService, IBlockService blockService)
        {
            this.tehnicalService = tehnicalService;
            this.blockService = blockService;
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
                Tehnicals = this.tehnicalService.GetAll<AllViewModel>(id),
            };

            return this.View(viewModel);
        }

    }
}
