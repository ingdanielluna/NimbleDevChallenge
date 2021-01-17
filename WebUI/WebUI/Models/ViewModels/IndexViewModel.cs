using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Shared.Models;

namespace WebUI.Models.ViewModels
{
    public class IndexViewModel
    {
        public BaseTea BaseTea { get; set; }
        public Flavour Flavour { get; set; }
        public Size Size { get; set; }
        public List<BaseTea> BaseTeas { get; set; }
        public List<Flavour> Flavours { get; set; }
        public List<ToppingsViewModel> Toppings { get; set; }
        public List<Size> Sizes { get; set; }
        public List<TeaSelectionViewModel> TeaSelections { get; set; }
        public List<SelectListItem> BaseTeaSelectListItems
        {
            get
            {
                List<SelectListItem> selectListItems = new List<SelectListItem>();

                foreach (var baseTea in BaseTeas)
                {
                    selectListItems.Add(
                        new SelectListItem()
                        {
                            Value = baseTea.Id.ToString(),
                            Text = baseTea.Name
                        });
                }

                return selectListItems;
            }
        }
        public List<SelectListItem> FlavourSelectListItems
        {
            get
            {
                List<SelectListItem> selectListItems = new List<SelectListItem>();

                foreach (var flavour in Flavours)
                {
                    selectListItems.Add(
                        new SelectListItem()
                        {
                            Value = flavour.Id.ToString(),
                            Text = flavour.Name
                        });
                }

                return selectListItems;
            }
        }

        //public int ToppingsCount
        //{
        //    get
        //    {
        //        int count = 0;

        //        if (Boba) count++;
        //        if (RedBean) count++;
        //        if (AiYuJelly) count++;
        //        if (BasilSeeds) count++;

        //        return count;
        //    }
        //}

        //public int TotalPrice
        //{
        //    get
        //    {
        //        int price = 0;

        //        price = price + ToppingsCount * ToppingPrice;

        //        return price;
        //    }
        //}

        //public void AddTeaSelection()
        //{
        //    TeaSelectionViewModel teaSelectionViewModel = new TeaSelectionViewModel()
        //    {
        //        BaseTea = this.BaseTea,
        //        Flavour = this.Flavour,
        //        Toppings = this.ToppingsCount
        //    };
        //}

        public IndexViewModel()
        {
            mockData();
        }

        public void mockData() 
        {
            BaseTeas = new List<BaseTea>();

            BaseTea bt1 = new BaseTea()
            {
                Id = Guid.NewGuid(),
                Name = "Black Tea"
            };
            BaseTea bt2 = new BaseTea()
            {
                Id = Guid.NewGuid(),
                Name = "Milk Tea"
            };

            BaseTeas.Add(bt1);
            BaseTeas.Add(bt2);

            Flavours = new List<Flavour>();

            Flavour f1 = new Flavour()
            {
                Id = Guid.NewGuid(),
                Name = "Lemon"
            };
            Flavour f2 = new Flavour()
            {
                Id = Guid.NewGuid(),
                Name = "Passionfruit"
            };
            Flavour f3 = new Flavour()
            {
                Id = Guid.NewGuid(),
                Name = "Yogurt"
            };

            Flavours.Add(f1);
            Flavours.Add(f2);
            Flavours.Add(f3);

            Toppings = new List<ToppingsViewModel>();

            ToppingsViewModel t1 = new ToppingsViewModel()
            {
                topping = new Topping()
                {
                    Id = Guid.NewGuid(),
                    Name = "Boba"
                },
                toppingSelected = false
            };
            ToppingsViewModel t2 = new ToppingsViewModel()
            {
                topping = new Topping()
                {
                    Id = Guid.NewGuid(),
                    Name = "Red Bean"
                },
                toppingSelected = false
            };
            ToppingsViewModel t3 = new ToppingsViewModel()
            {
                topping = new Topping()
                {
                    Id = Guid.NewGuid(),
                    Name = "Basil Seeds"
                },
                toppingSelected = false
            };

            Toppings.Add(t1);
            Toppings.Add(t2);
            Toppings.Add(t3);

            Sizes = new List<Size>();

            Size s1 = new Size()
            {
                Id = Guid.NewGuid(),
                Name = "L"
            };
            Size s2 = new Size()
            {
                Id = Guid.NewGuid(),
                Name = "M"
            };
            Size s3 = new Size()
            {
                Id = Guid.NewGuid(),
                Name = "S"
            };

            Sizes.Add(s1);
            Sizes.Add(s2);
            Sizes.Add(s3);


        }
    }
}
