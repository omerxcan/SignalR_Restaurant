namespace Restoran.WebUI.ViewModels.TestimonialViewModels
{
    public class UpdateTestimonialViewModel
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public bool Status { get; set; }
    }
}
