using BusinessLogicLayer.DTOs.Enums;

namespace BusinessLogicLayer.DTOs
{
    public record ProductAddRequest(string ProductName, CategoryOptions Category, double UnitPrice, int QuantityInStock)
    {
        public ProductAddRequest() : this(default, default, default, default) { }
    }
}
