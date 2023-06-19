using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterfaces
{
    public interface IRepositoryUnitOfWork
    {
        public Task<bool> Save();
    }
}
