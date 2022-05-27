using System.Collections;
using System.Collections.Generic;

namespace LesGeneriques
{
    public interface IDao <T>
    {

        void Create(T o);
        bool Delete(T o);
        bool Update(T o);
        T FindById(int id);
        List<T> FindAll();


    }
}