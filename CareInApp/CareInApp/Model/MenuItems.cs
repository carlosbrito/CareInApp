using System;
using System.Collections.Generic;
using System.Text;

namespace CareInApp.Model
{
    public class MenuItems
    {
        public MenuItems(string name, string link, string icon)
        {
            Name = name;
            Link = link;
            Icon = icon;
        }

        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
