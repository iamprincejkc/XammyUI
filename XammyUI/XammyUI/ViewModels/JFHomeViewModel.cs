using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using XammyUI.Models;

namespace XammyUI.ViewModels
{
    public class JFHomeViewModel : BindableBase
    {
        public ObservableCollection<Categories> categories { get; set; }
        public ObservableCollection<PopularFood> popularFood { get; set; }
        public JFHomeViewModel()
        {
            categories = new ObservableCollection<Categories>
            {
                new Categories { Image="Burger", Title="Burger" },
                new Categories { Image="Seafood", Title="Seadfood" },
                new Categories { Image="SoftDrink", Title="Soft drink" }
            };
            popularFood = new ObservableCollection<PopularFood>
            {
                new PopularFood { Image="MenuOption", Title="Chicken Royal", Type="Hamburger", Price="$12"},
                new PopularFood { Image="MenuOption", Title="King Loobster", Type="Seafood", Price="$25" },
                new PopularFood { Image="MenuOption", Title="Chicken Royal", Type="Hamburger", Price="$12"},
            };
        }
    }
}
