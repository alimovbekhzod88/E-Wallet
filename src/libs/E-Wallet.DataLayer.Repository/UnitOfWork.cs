using GenericServices;


namespace E_Wallet.DataLayer.Repository
{
    public class UnitOfWork : BaseUnitOfWork, IUnitOfWork
    {
        public UnitOfWork( ICrudServices crudServices,
            IServiceProvider serviceProvider)
            : base(crudServices, serviceProvider)
        {
            
        }
        public IUserRepository UserRepository
        { get => GetRepository<IUserRepository>(); }
    }
}
