using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Global.shared;
using System.Runtime.CompilerServices;

namespace E_Wallet.DataLayer.Repository
{
    public class UserDlDto<TDto> : EntityDto<TDto, User>
        where TDto : UserDlDto<TDto>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public int DocumentTypeId { get; set; }
        public string DocSeriaNumber { get; set; } = null!;
        public virtual string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public string? EmailAddress { get; set; }

        public override User CreateEntity()
        {
            var entity =  base.CreateEntity();
            entity.StateId = StateIdConst.ACTIVE;
            SetPassword(entity, true);
            return entity;
        }

        public override void UpdateEntity(User entity)
        {
            base.UpdateEntity(entity);
            SetPassword(entity: entity);
        }

        private void SetPassword(User entity, bool isNewEntity = false)
        {
            if(isNewEntity || !PasswordHash.NullOrEmpty())
            {
                entity.PasswordHash = HashHelper.CreateRandomSalt();
                entity.PasswordHash = new CustomePasswordHasher().HashPassword(password: PasswordHash, salt: PasswordSalt);
            }
        }
    }
}
