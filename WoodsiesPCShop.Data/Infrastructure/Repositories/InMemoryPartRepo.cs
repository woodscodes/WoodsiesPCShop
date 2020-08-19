using System;
using System.Collections.Generic;
using System.Text;
using WoodsiesPCShop.Core.Models;
using WoodsiesPCShop.Data.Infrastructure.Contracts;

namespace WoodsiesPCShop.Data.Infrastructure.Repositories
{
    public class InMemoryPartRepo : IPartData
    {
        private List<Part> _partsDb;

        public InMemoryPartRepo()
        {
            _partsDb = new List<Part>
            {
                new Part {PartId = 1, Manufacturer = "Gigabyte", Model = "RTX 2070", Price = 280f, Img = "/gpu/GigabyteRtx2070.jpg", CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, ius dignissim voluptatibus an. Vide appareat te pri. Pri accusamus referrentur ne. Usu cu amet natum eloquentiam, ei sanctus explicari cum."},
                new Part {PartId = 2, Manufacturer = "Intel", Model = "i9-9900k", Price = 385f, Img = "/cpu/i9-9900k.jpg", CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet, ius dignissim voluptatibus an. Vide appareat te pri. Pri accusamus referrentur ne. Usu cu amet natum eloquentiam, ei sanctus explicari cum."},
                new Part {PartId = 3 , Manufacturer = "Crucial", Model = "Ballistix 2x8gb", Price = 92f, Img = "/ram/Ballistix16gb.jpg", CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet, ius dignissim voluptatibus an. Vide appareat te pri. Pri accusamus referrentur ne. Usu cu amet natum eloquentiam, ei sanctus explicari cum."},
                new Part {PartId = 4, Manufacturer = "CoolerMaster", Model = "MasterCase", Price = 45, Img = "/case/CoolerMasterMasterCaseAtxMidTower.jpg", CategoryId = 4,
                            Description = "Lorem ipsum dolor sit amet, ius dignissim voluptatibus an. Vide appareat te pri. Pri accusamus referrentur ne. Usu cu amet natum eloquentiam, ei sanctus explicari cum."}
            };
        }

        public IEnumerable<Part> GetAllParts()
        {
            return _partsDb;
        }
    }
}
