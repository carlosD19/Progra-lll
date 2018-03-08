using System.Configuration;

namespace VisorImagenDAL
{
    public static class Configuracion
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public static string ConStr
        {
            get { return conStr; }
        }

    }
}
