using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Catalogue.Models.ViewModels
{
   public class DropDownCategoriesView
    {


        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}
