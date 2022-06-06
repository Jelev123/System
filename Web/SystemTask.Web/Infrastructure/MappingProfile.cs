namespace SystemTask.Web.Infrastructure
{
    using AutoMapper;
    using SystemTask.Data.Models;
    using SystemTask.Data.Models.ViewModel;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Tehnical, AllViewModel>();
            this.CreateMap<TehnicalBlock, TehnicalBloksInputModel>();
            this.CreateMap<Block, AllViewModel>();
            this.CreateMap<Block, TehnicalBloksInputModel>();
            this.CreateMap<TehnicalEmployee, TehnicalEmployeesInputModel>();
            this.CreateMap<TehnicalSystem, TehnicalSystemInputModel>();
        }
    }
}
