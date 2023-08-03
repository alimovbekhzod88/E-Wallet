using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Global.shared
{
    public interface IBaseEntityRepository<TId, TEntity,TCreateDto,TUpdateDto> :
        IBaseEntityRepository<TId,TEntity>,
        IStatusGenericHandler,
        IStatusGeneric,
        IHaveIdProp<TId>
            where TEntity : class
            where TCreateDto : EntityDto<TCreateDto,TEntity> 
            where TUpdateDto : EntityDto<TUpdateDto,TEntity>
    {
        TEntity Update(TUpdateDto updateDto, Action<TEntity> validation = null);

        TEntity Create(TCreateDto createDto, Action<TEntity> validation = null);
    }
}