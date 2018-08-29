using System;
using System.Collections.Generic;
using System.Text;

namespace LBulbRecord.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        New
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
