using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace WoodsiesPCShop.Core.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string Manufacturer { get; set; }
        public string ImgThumbnail { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
