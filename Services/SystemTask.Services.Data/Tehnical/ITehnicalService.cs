namespace SystemTask.Services.Data.Tehnical
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SystemTask.Data.Models.ViewModel;

    public interface ITehnicalService
    {
        Task Create(CreateTehnicalViewModel create);

        IEnumerable<AllViewModel> GetAll<T>(int id);

        //int ById(int id);

    }
}
