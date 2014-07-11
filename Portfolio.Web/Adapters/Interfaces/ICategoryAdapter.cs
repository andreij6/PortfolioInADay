using Portfolio.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Web.Adapters.Interfaces
{
    public interface ICategoryAdapter
    {
        List<Category> getCategories();
    }
}
