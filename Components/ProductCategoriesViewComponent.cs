﻿using Microsoft.AspNetCore.Mvc;
using IntexQueensSlay.Models;

namespace IntexQueensSlay.Components
{
    public class ProductCategoriesViewComponent : ViewComponent
    {
        private ISlayRepository _slayRepo;
        //Constructor
        public ProductCategoriesViewComponent(ISlayRepository temp)
        {
            _slayRepo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedProductCat = RouteData?.Values["productCat"];

            var productCats = _slayRepo.Products
                .Select(x => x.Category1)
                .Distinct()
                .OrderBy(x => x);

            return View(productCats);
        }
    }
}

