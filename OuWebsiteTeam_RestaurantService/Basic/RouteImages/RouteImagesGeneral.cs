using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuWebsiteTeam_RestaurantService.Basic.RouteImages
{
    public class RouteImagesGeneral
    {
        private string RouteGeneral = "";

        public string RouteImagesPNGs(string imagename)
        {
            return RouteGeneral + "/" + imagename;
        }
    }
}
