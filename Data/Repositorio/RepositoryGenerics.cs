using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public class RepositoryGenerics<T> : IGeneric<T>, IDisposable where T : class
    {

    }
    
}
