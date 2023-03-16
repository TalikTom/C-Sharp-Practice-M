using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO
{
    public class Menu
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<MenuItem> menuItems { get; set; }


        public string GetCheapestItem(Menu menu)
        {
            // Check if there are any items in the menu
            if (menu.menuItems == null || menu.menuItems.Count == 0)
            {
                return null; // Return null if there are no items
            }

            // Find the cheapest item in the menu
            MenuItem cheapestItem = menu.menuItems[0];
            foreach (MenuItem item in menu.menuItems)
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
