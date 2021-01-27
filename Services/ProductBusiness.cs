using ProductCategory.Data;
using ProductCategory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Services
{
    public class ProductBusiness
    {
        BookStoreDbContext db = new BookStoreDbContext();


        public IList<Product> GetProducts()
        {
            var productc = db.Products.Select(x => new Product()
            {
                Id = x.Id,
                Name = x.Name,
                Author = x.Author,
                CategoryId = x.Category.Id,
                CategoryName = x.Category.Name
            }).ToList();

            return productc;
        }

        public Product GetProductsById(int id)
        {
            return db.Products.Find(id);
        }
        public bool GetProductByName(string name)
        {
            var selectedname= db.Products.Select(a => new Product()
            {
                Name = a.Name
            }).Where(b => b.Name == name).ToList();
            if (selectedname != null)
                return true;
            return false;
        }
        public IList<Product> GetProductByCategoryId(int categoryid)
        {
            var productc= db.Products.Select(x=>new Product()
            {
                Id = x.Id,
                Name = x.Name,
                Author = x.Author,
                CategoryId = x.Category.Id,
                CategoryName = x.Category.Name
            }).Where(y => y.CategoryId == categoryid).ToList();

            return productc;
        }

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
