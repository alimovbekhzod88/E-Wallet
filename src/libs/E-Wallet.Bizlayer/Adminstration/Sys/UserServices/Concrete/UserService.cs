﻿using System.Linq;
using Global.shared;
using GenericServices;
using Global.EF;
using Microsoft.EntityFrameworkCore;

namespace E_Wallet.Bizlayer.Adminstration
{
    public class UserService : StatusGenericHandler, IUserService
    {
        private readonly IUserRepository repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IAuthService authService;

        public UserService( 
            IUnitOfWork unitOfWork,
            IAuthService authService
            )
        {
            repository = unitOfWork.UserRepository;
            this.unitOfWork = unitOfWork;
            this.authService = authService;
        }
        private IQueryable<TDto> GetQuery<TDto>()
                where TDto : class
        {
            
        }

         public PagedResult<UserListDto> GetUserList(SortFilterPageOptions options)
                 => GetQuery<UserListDto>()
                    .SortFilter(options)
                        .AsPagedResult(options);
    
        public UserDto GetUser()
             => new UserDto();
        }
            public UserDto GetUserById(int userId)
        {
            var userDto = GetQuery<UserDto>().
                        FirstOrDefault(user => user.Id == userId);

            if (userDto == null)
                AddError(errorMessage: "По вашему запросу запись не найдено");

            return userDto!;
        }
}
