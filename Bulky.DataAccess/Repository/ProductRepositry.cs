using BulkyBook.DataAcces.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepositry : Repository<Product>, IProductRepositry
    {
        private ApplicationDbContext _db;
        public ProductRepositry(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }       

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
