using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class ToppingsViewModel
    {
        public bool toppingSelected { get; set; } = false;

        public Topping topping { get; set; }

    }
}
