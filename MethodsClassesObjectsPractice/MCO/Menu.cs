using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public class Menu
    {

        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<MenuItem> MenuItems { get; set; }


        public string GetCheapestItem(Menu menu)
        {
            // Check if there are any items in the menu
            if (menu.MenuItems == null || menu.MenuItems.Count == 0)
            {
                return null; // Return null if there are no items
            }

            // Find the cheapest item in the menu
            MenuItem cheapestItem = menu.MenuItems[0];
            foreach (MenuItem item in menu.MenuItems)
            {
                if (item.Price < cheapestItem.Price)
                {
                    cheapestItem = item;
                }
            }

            return cheapestItem.Title;
        }
    }
}
