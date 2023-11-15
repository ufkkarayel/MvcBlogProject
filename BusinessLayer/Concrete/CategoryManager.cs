using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager 
    {
        Repository<Category> repo = new Repository<Category>();
        public List<Category> GetAll()
        {
            return repo.List();
        }
        
    }
}
