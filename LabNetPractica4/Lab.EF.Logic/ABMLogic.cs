using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal interface ABMLogic<T>
    {
        List<T> GetAll();
        void Add(T nombre);
        void Update(T nombre);
        void Remove(int id);
    }
}
