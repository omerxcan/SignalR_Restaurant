namespace Restoran.Api.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool Status { get; set; } 
    }
}
