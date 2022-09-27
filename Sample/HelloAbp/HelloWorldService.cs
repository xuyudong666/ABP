using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HelloAbp
{
    [Dependency(ServiceLifetime.Transient)]
    public class HelloWorldService:ITransientDependency,ISingletonDependency,IScopedDependency
    {
        public void Run()
        {
            Console.WriteLine("Hello World");
        }
    }
}
