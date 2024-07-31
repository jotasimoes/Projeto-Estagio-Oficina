using System.Web;
using System.Web.Mvc;

namespace OficinaV2WebAPi
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
