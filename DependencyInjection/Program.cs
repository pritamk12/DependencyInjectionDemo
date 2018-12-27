using Autofac;
using System;

namespace DependencyInjection
{
    class Program
    {
        private static IContainer Container { get; set; }
        //private static IFileService service;
        static void Main(string[] args)
        {
            // Create your builder
            var builder = new ContainerBuilder();

            // Register required types
            builder.RegisterType<PdfFileService>().As<IFileService>();
            builder.RegisterType<Consumer>().As<IConsumer>();

            // Build container 
            Container = builder.Build();

            // Call consumer
            using (var scope = Container.BeginLifetimeScope())
            {
                scope.Resolve<IConsumer>();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Returns file service instance based on file service name type.
        /// </summary>
        /// <param name="fileServiceName"></param>
        /// <returns></returns>
        //private static IFileService GetFileServiceInstance(string fileServiceName)
        //{
        //    if (fileServiceName == "PDF")
        //    {
        //        return new PdfFileService();
        //    }
        //    else
        //    {
        //        return new HtmlFileService();
        //    }
        //}
    }
}
