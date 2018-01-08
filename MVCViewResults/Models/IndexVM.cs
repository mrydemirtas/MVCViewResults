using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCViewResults.Models
{
    public class IndexVM
    {
        public List<MenuVM> Menus { get; set; }
        public List<CategoryVM> Categories { get; set; }
        public ContentVM Content { get; set; }

    }
}