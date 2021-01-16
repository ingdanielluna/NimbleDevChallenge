using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Enums;

namespace WebUI.Models.ViewModels
{
    public class TeaSelectionViewModel
    {
        public string Size { get; set; }
        public BaseTeaType BaseTea { get; set; }
        public FlavourType Flavour { get; set; }
        public int Toppings { get; set; }
        public int Price { get; set; }

    }
}
