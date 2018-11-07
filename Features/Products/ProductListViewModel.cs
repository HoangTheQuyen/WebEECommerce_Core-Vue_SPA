using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebEECommerce_Core_Vue_SPA.Features.Products;

namespace ECommerce.Features.Products
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string Thumbnail { get; set; }
    }
}