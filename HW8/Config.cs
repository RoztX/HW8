using Autofac;

namespace HW8
{
    public class Config
    {
        public IContainer RegistrarDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OutputService>().As<IOutput>();
            builder.RegisterType<SortService>().As<ISort>();
            builder.RegisterType<FilterService>().As<IFilter>();
            builder.RegisterType<Starter>();

            var container = builder.Build();
            return container;
        }
    }
}
