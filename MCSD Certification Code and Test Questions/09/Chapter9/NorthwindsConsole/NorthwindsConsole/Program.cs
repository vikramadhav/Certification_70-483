using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NorthwindsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Select
            using (NorthwindsEntities db = new NorthwindsEntities())
            {
                var categories = from c in db.Categories
                                 select c;

                foreach (Category category in categories)
                {
                    Debug.WriteLine(string.Format("CategoryId: {0}, CategoryName: {1}", category.CategoryID, category.CategoryName));
                }
            }

            //Select with a join
            using (NorthwindsEntities db = new NorthwindsEntities())
            {
                var products = from c in db.Categories
                               join p in db.Products on c.CategoryID equals p.CategoryID
                               select p;

                foreach (Product product in products)
                {
                    Debug.WriteLine(string.Format("ProductName: {0}, CategorName: {1}", product.ProductName, product.Category.CategoryName));
                }
            }

            //Add a record
            using (NorthwindsEntities db = new NorthwindsEntities())
            {
                Category category = new Category()
                {
                    CategoryName = "Alcohol",
                    Description = "Happy Beverages"
                };

                db.Categories.Add(category);
                db.SaveChanges();
            }

            //Update a record
            using (NorthwindsEntities db = new NorthwindsEntities())
            {
                Category category = db.Categories.First(c => c.CategoryName == "Alcohol");
                category.Description = "Happy People";
                db.SaveChanges();
            }

            //Delete a record
            using (NorthwindsEntities db = new NorthwindsEntities())
            {
                Category category = db.Categories.First(c => c.CategoryName == "Alcohol");
                db.Categories.Remove(category);
                db.SaveChanges();
            }

            //Call a stored procedure.
            using (NorthwindsEntities db = new NorthwindsEntities())
            {
                var custOrderHist = db.CustOrderHist("ALFKI");
                
                foreach (CustOrderHist_Result result in custOrderHist)
	            {
		            Debug.WriteLine(string.Format("ProductName: {0}, Total: {1}", result.ProductName, result.Total));
	            }
            }
        }
    }
}
