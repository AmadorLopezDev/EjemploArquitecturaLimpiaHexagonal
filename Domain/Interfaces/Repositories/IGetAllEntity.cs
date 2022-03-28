using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Domain.Interfaces.Repositories
{
    public interface IGetAllEntity<TEntity>
    {
        IEnumerable<TEntity> GetAll();
    }
}
