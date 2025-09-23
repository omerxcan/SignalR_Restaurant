﻿namespace Restoran.WebUI.ViewModels.ProductViewModels
{
    public class UpdateProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool ProductStatus { get; set; }
    }
}
