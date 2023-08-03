using GenericServices;
using Microsoft.EntityFrameworkCore;
using Global.shared;

namespace E_Wallet.DataLayer.Repository
{
    public class UserRepository : BaseEntityRepository<int, User, CreateUserDlDto, UpdateUserDlDto>,
        IUserRepository
    {
        public UserRepository(ICrudServices crudServices)
            : base(crudServices)
        {
        }

        protected override IQueryable<User> ByIdQuery()
            => base.ByIdQuery();
        
        public User ByFirstName(string firstName)
        {
            var user = ByIdQuery().FirstOrDefault(user => user.FirstName == firstName);

            if (user == null)
                AddEntityNotFoundError();

            return user;
        }

        protected override void OnCreate(User entity,
            CreateUserDlDto dto)
            => Validate(null, dto);

        protected override void OnUpdate(User entity,
            UpdateUserDlDto dto)
            => Validate(entity, dto);

        private void Validate<TDto>(User entity,
            UserDlDto<TDto> dto)
            where TDto : UserDlDto<TDto>
        {
            var query = DbSet.AsQueryable();

            if (entity != null)
                query = query.Where(user => user.Id != entity.Id);

            if (!string.IsNullOrEmpty(dto.Email) && query.ByEmail(email : dto.Email, 
                    isIncludePassive: true).Any())
                AddError($"Ползователь с этим Email ({dto.Email}) уже существует.", nameof(dto.Email));
        }
    }
}