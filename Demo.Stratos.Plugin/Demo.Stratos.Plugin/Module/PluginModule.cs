using Demo.Stratos.Plugin.Services;
using Nancy;

namespace Demo.Stratos.Plugin.Module
{
    public class PluginModule : NancyModule
    {
        private readonly IFoo m_foo;
        public PluginModule(IFoo foo) : base("api/plugin/")
        {
            EnableCors();
            m_foo = foo;
            Get["/getString"] = parameters =>
            {
                var result = m_foo.GetString();
                return Response.AsJson(result);
            };
        }

        private void EnableCors()
        {
            After.AddItemToEndOfPipeline(x => { x.Response.WithHeader("Access-Control-Allow-Origin", "*"); });
        }
    }
}