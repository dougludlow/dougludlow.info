using Karbon.Cms.Web;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(dougludlow.info.App_Start.KarbonCmsConfig), "Initialize")]
namespace dougludlow.info.App_Start
{
    public class KarbonCmsConfig
    {
        public static void Initialize()
        {
            new WebBootManager().Initialize();
        }
    }
}