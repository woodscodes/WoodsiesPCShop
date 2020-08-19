using System;
using System.Collections.Generic;
using System.Text;
using WoodsiesPCShop.Core.Models;

namespace WoodsiesPCShop.Data.Infrastructure.Contracts
{
    public interface IPartData
    {
        IEnumerable<Part> GetAllParts();
    }
}
