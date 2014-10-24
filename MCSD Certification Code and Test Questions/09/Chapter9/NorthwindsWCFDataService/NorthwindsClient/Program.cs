using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NorthwindsClient.NorthwindsServiceReference;
using System.Diagnostics;
using System.Data.Services.Client;
using System.Net;
using System.IO;

namespace NorthwindsClient
{
    class Program
    {
        static void Main(string[] args)
        {                        
            NorthwindsEntities db = new NorthwindsEntities(new Uri("http://localhost:8999/NorthwindsService.svc/"));

            //Simple Select
            //var categories = from c in db.Categories
            //                    select c;

            //foreach (Category category in categories)
            //{
            //    Debug.WriteLine(string.Format("CategoryId: {0}, CategoryName: {1}", category.CategoryID, category.CategoryName));
            //}

            //Add a record
            //Category category = new Category()
            //{
            //    CategoryName = "Alcohol",
            //    Description = "Happy Beverages"
            //};

            //db.AddToCategories(category);
            //DataServiceResponse response = db.SaveChanges();

            //if (response.First().StatusCode == (int)HttpStatusCode.Created)
            //{
            //    Debug.WriteLine("New CategoryId: {0}", category.CategoryID);
            //}
            //else
            //{
            //    Debug.WriteLine("Error: {0}", response.First().Error.Message);
            //}

            //Update a record
            //Category category = db.Categories.Where(c => c.CategoryName == "Alcohol").FirstOrDefault();
                            
            //category.Description = "Happy People";

            //db.UpdateObject(category);

            //db.SaveChanges();            

            //Delete a record
            //Category category = db.Categories.Where(c => c.CategoryName == "Alcohol").FirstOrDefault();
            //db.DeleteObject(category);
            //db.SaveChanges();
            
            //Request data as JSON using a client request.
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:8999/NorthwindsService.svc/Categories(1)?$select=CategoryID,CategoryName,Description");
                                   
            req.Accept = "application/json;odata=verbose";
            
            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {                
                Stream s = resp.GetResponseStream();                                
                StreamReader readStream = new StreamReader(s);
              
                string jsonString = readStream.ReadToEnd();

                Debug.WriteLine(jsonString);
                
                resp.Close();
                readStream.Close();                                                
            } 
        }
    }
}
