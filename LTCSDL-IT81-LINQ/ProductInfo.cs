using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_IT81_LINQ
{
    public class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;

        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}, Number in Stock ={ 2}", Name, Description, NumberInStock);
        }

    }

    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int NumberInStock { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return string.Format("ProductId = {0}, ProductName = {1}, NumberInStock = {2}, CategoryId = {3}",
                ProductId, ProductName, NumberInStock, CategoryId);
        }
    }
}
