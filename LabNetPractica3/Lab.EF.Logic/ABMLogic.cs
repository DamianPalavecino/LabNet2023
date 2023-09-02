using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    interface ABMLogic<T>
    {
        List<T> GetAll();
        void Add(T Elemento);
        void Update(T Elemento);
        void Remove(string id);
    }
}
