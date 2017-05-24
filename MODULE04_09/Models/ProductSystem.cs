using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODULE04_09.DAL;

namespace MODULE04_09.Models
{
    public class ProductSystem
    {
        //把原本寫在controller中的entity部分寫到model中來，對controller做了遮蔽存取資料庫的動作。
        public Product GetProductByID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.ProductID == id
                        select p;

            //只列第一筆
            var result = query.First();

            return result;

        }

        public IEnumerable<Product> GetProductsByCategoryID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id
                        select p;

            var result = query.ToList();
            return result;
        }
    }
}
