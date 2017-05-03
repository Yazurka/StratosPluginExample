using Demo.Stratos.Plugin.Services;
using LightInject;

namespace Demo.Stratos.Plugin
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IFoo, Foo>(new PerRequestLifeTime());
        }
    }
}