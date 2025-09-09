namespace dotnet_dependencies_project.Services
{
    public interface IProductService
    {
        Product CreateProduct(Product product);
        Product GetProduct(int id);
        IEnumerable<Product> GetAllProducts();
        void DeleteProduct(int id);
        Product UpdateProduct(Product product);
    }
}