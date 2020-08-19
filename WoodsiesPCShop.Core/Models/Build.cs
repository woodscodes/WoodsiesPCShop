using System;
using System.Collections.Generic;
using System.Text;

namespace WoodsiesPCShop.Core.Models
{
    public class Build
    {
        public int BuildId { get; set; }
        public string BuildName { get; set; }
        public List<Part> Parts { get; set; }
        public float Price { get; set; }
    }
}
