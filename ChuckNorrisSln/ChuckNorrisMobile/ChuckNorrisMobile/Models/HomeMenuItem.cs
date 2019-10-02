using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisMobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        ChuckNorris
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
