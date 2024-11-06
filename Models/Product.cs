namespace Project_Book_Shop.Models
{
    public class Product
    {
            public int ProductId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public int? CategoryId { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public string CoverImage { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
    }
}
