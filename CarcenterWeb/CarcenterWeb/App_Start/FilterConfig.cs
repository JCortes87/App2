using System.Web;
using System.Web.Mvc;

namespace CarcenterWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //Habiilitar el filtro de sesion para cada submit en la aplicación
            filters.Add(new Filters.VerificarSesion());

        }
    }
}
