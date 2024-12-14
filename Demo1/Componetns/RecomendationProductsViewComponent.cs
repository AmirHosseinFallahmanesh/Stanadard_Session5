using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Componetns
{
    public class RecomendationProductsViewComponent:ViewComponent
    {

        public RecomendationProductsViewComponent()
        {
            //inject service
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new List<Product>()
                {
                    new Product()
                    {
                        Name="s24 ultra",
                        ImageUrl="/img/s24.webp",
                        Price=2000,
                    },
                     new Product()
                    {
                        Name="A3",
                        ImageUrl="/img/a3.webp",
                        Price=400,
                    },
                      new Product()
                    {
                        Name="Iphone 16 ",
                        ImageUrl="/img/iphne16.webp",
                        Price=1500,
                    }
                };
            return View(model);
        }
    }
}
