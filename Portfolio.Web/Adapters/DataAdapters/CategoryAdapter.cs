using Portfolio.Data;
using Portfolio.DataModels;
using Portfolio.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Web.Adapters.DataAdapters
{
    public class CategoryAdapter : ICategoryAdapter
    {
        public List<Category> getCategories()
        {
            List<Category> model;

            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Categories.ToList();
            }

            return model;
        }
    }
}