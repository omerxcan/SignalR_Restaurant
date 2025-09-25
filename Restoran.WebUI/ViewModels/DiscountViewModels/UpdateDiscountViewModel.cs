namespace Restoran.WebUI.ViewModels.DiscountViewModels
{
    public class UpdateDiscountViewModel
    {
        public int DiscountID { get; set; }
        public string Title { get; set; } = null!;
        public string Amount { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
