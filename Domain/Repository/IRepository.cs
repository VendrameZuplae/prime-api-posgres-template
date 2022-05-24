using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepository<T> where T: BaseModel
    {
        void Create(T model);
        T Read(long id);
        List<T> Read();
        void Update(T model);
        void Delete(long id);

    }
}
