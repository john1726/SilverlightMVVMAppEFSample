using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using WcfEntitiesSample.Data;

namespace WcfEntitiesSample.Model
{
    public class ProductManager
    {
        public Product GetProductById(int productID)
        {
            IEnumerable<Product> products = null;

                var db = new AdventureWorksEntities();
                //db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s); // See http://blog.oneunicorn.com/2013/05/08/ef6-sql-logging-part-1-simple-logging/
                products = db.vProductProductInventories
                    .Where(prod => prod.ProductID == productID)
                    .Select(p => new Product
                    {
                        ProductID = p.ProductID,
                        Name = p.Name,
                        InventoryCount = p.InventoryCount,
                        Description = p.Description
                    });

            return products.ToList()[0];
        }
    }
}
