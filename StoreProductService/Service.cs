using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Product;

namespace StoreProductService
{  // դրսից փոխանցենք Product կոչվող entity-ներ, որը ունի ID, name, group, price
   // մի հատ մեթոդ StoreProduct ,որը վերդարձնի տվյալների կառուցվածք Result անումով, որտեղ գրված է Status(like success, failure, etc.), Message
   // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        private List<Productik> Products = new List<Productik>();
        private void GenerateProducts()
        {
            Productik p1 = new Productik(1,"Snickers", "Group1", 250);
            Productik p2 = new Productik(8, "Mars", "Group4", 250);
            Productik p3 = new Productik(2, "Bounty", "Group2", 350);
            Productik p4 = new Productik(5, "Twix", "Group9", 450);
            Productik p5 = new Productik(6, "MilkyWay", "Group3", 150);
            Products.Add(p1);
            Products.Add(p2);
            Products.Add(p3);
            Products.Add(p4);
            Products.Add(p5);
        }
        public ProductResult StoreProduct(Productik p)
        {
            GenerateProducts();
            ProductResult result = new ProductResult();
            for (int i = 0; i < Products.Count; i++)
            {
                if (p.ID == Products[i].ID)
                {
                    result.Message = "This ID is already used";
                    result.Status = "Failure";
                    return result;
                }
                if (p.name.Length == 0)
                {
                    result.Message = "Name is empty";
                    result.Status = "Failure";
                    return result;
                } }
            Products.Add(p);
            result.Message = "Added";
            result.Status = "Success";
            return result;
            
           
        }
    }
}
