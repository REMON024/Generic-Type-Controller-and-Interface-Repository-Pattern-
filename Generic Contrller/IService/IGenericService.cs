using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Contrller.IService
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int Id);
        List<T> Insert(T Insert);
        List<T> Delete(int Id);
    }
}
