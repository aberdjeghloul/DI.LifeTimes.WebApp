using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    public class SingletonOperation : ISingletonOperation
    {
        public Guid Id { get; }
        public SingletonOperation()
        {
            Id = Guid.NewGuid();
        }
        
    }
}
