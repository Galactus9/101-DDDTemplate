using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryImplementation
{
    internal class RepositoryUnitOfWork : IRepositoryUnitOfWork
    {
        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
