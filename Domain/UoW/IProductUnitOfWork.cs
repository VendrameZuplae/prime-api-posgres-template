using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UoW
{
    public interface IProductUnitOfWork : IBaseUnitOfWork
    {
        public IProductUnitOfWork ProductUnitOfWork { get; set; }
    }
}
