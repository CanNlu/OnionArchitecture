using OnionArchitecture.Domain.Common;

namespace OnionArchitecture.Domain.Entities
{
    public class Category : BaseEntity
    {
        public int RowNumber { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
