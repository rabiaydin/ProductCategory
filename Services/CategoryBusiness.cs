using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCategory.Data;
using ProductCategory.Models;

namespace ProductCategory.Services
{
    public class CategoryBusiness
    {
        BookStoreDbContext db = new BookStoreDbContext();

        public IList<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoriesById(int id)
        {
            return db.Categories.Find(id);
        }


        public int AddCategory(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges();
        }

        public int UpdateCategory(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int DeleteCategory(Category category)
        {
            db.Categories.Remove(category);
            return db.SaveChanges();
        }
    }
}
