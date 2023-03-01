using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TkaniProbnikDem
{
    public class Product
    {
        public string ProductName;
        public string ProductDescription;
        public string ProductManufacturer;
        public double ProductCost;
        public int ProductQuantityInStock;

        public Product(DataRow row)
        {
            ProductName = Convert.ToString(row["ProductName"]);
            ProductDescription = Convert.ToString(row["ProductDescription"]);
            ProductManufacturer = Convert.ToString(row["ProductManufacturer"]);
            ProductCost = Convert.ToInt32(row["ProductCost"]);
            ProductQuantityInStock = Convert.ToInt32(row["ProductQuantityInStock"]);
        }
        public static List<Product> GetProduct(string tbSource)
        {
            List<Product> product = new List<Product>();
            DataTable datatable = BD.Instance.SqlZapros($"SELECT `ProductName`,`ProductDescription`,`ProductManufacturer`,`ProductCost`,`ProductQuantityInStock` FROM `Product` WHERE `ProductName` LIKE '%{tbSource}%' OR `ProductManufacturer` LIKE '%{tbSource}%'");
            foreach (DataRow row in datatable.Rows)
            {
                Product p = new Product(row);
                product.Add(p);
            }
            return product;
        }
    }
}
