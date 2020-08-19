using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoodsiesPCShop.Core.Models;
using WoodsiesPCShop.Data.Infrastructure.Contracts;
using WoodsiesPCShop.WebUI.ViewModels;

namespace WoodsiesPCShop.WebUI.Controllers
{
    public class PartsController : Controller
    {
        private readonly IPartData _partDb;

        public PartsController(IPartData partDb)
        {
            _partDb = partDb;
        }

        public IActionResult List()
        {
            var partViewModel = new PartViewModel { Parts = _partDb.GetAllParts() };

            if (partViewModel.Parts != null)
                return View(partViewModel);
            else
                return View("Home/Index.cshtml");
        }
    }
}