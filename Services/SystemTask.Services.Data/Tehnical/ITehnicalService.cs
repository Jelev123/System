namespace SystemTask.Services.Data.Tehnical
{
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;
    using SystemTask.Data.Models.ViewModel;

    public interface ITehnicalService
    {
        Task Create(CreateTehnicalViewModel create);

        IEnumerable<T> GetAllTehnical<T>(int id);

        IEnumerable<T> GetAllSystems<T>(int id);

        IEnumerable<T> GetAllBlocks<T>(int id);

        IEnumerable<T> GetAllEmployees<T>(int id);

    }
}
