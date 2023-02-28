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
        public int ProductCost;
        public int ProductQuantityInStock;

        public Product(DataRow row)
        {
            ProductName = Convert.ToString(row["ProductName"]);
            ProductDescription = Convert.ToString(row["ProductDescription"]);
            ProductManufacturer = Convert.ToString(row["ProductManufacturer"]);
            ProductCost = Convert.ToInt32(row["ProductCost"]);
            ProductQuantityInStock = Convert.ToInt32(row["ProductQuantityInStock"]);
        }
        public static List<Product> GetProduct()
        {
            List<Product> product = new List<Product>();
            DataTable datatable = BD.Instance.SqlZapros("SELECT `ProductName`,`ProductDescription`,`ProductManufacturer`,`ProductCost`, `ProductQuantityInStock` FROM `Product`");
            foreach (DataRow row in datatable.Rows)
            {
                Product p = new Product(row);
                product.Add(p);
            }
            return product;
        }
        public static List<Product> SortingASC() 
        { 
            List<Product> product = new List<Product>();
            DataTable dt = BD.Instance.SqlZapros("SELECT `ProductName`,`ProductDescription`,`ProductManufacturer`,`ProductCost`, `ProductQuantityInStock` FROM `Product` ORDER BY `ProductCost` ASC");
            foreach (DataRow row in dt.Rows)
            {
                Product s = new Product(row);
                product.Add(s);
            }
            return product;
        }
    }
}
