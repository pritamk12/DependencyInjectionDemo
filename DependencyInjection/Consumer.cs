using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Consumer : IConsumer
    {
        public Consumer(IFileService service)
        {
            service.print();
        }
    }
}
