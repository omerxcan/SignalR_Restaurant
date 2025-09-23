namespace Restoran.WebUI.ViewModels.CategoryViewModels
{
    public class UpdateCategoryViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool Status { get; set; }
    }
}
