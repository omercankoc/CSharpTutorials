using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFrameworkSample
{
    class ProductDAL
    {
        public List<Product> GetAll()
        {
            // Metod bittiği zaman işi biten nesneleri bellekden atma işlemini gerçekleştirir. -(GARBAGE COLLECTOR)-
            // using ile nesne zorla bellekden atılır. -(DISPOZE)- 
            using (ProductContext context = new ProductContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            // Metod bittiği zaman işi biten nesneleri bellekden atma işlemini gerçekleştirir. -(GARBAGE COLLECTOR)-
            // using ile nesne zorla bellekden atılır. -(DISPOZE)- 
            // Burada direk veri tabanında sorgu işlemi yapıyor... (ihtiyaç olan veri alınır - büyük veri setlerinde kullanışlı)
            using (ProductContext context = new ProductContext())
            {
                // ToLower() ile arama yapılacak key ve DB'deki sorgulanacak veriler küçük harfe çevrildi. C# küçük-büyük harf duyarlıdır. 
                return context.Products.Where(p=>p.Brand.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            // Metod bittiği zaman işi biten nesneleri bellekden atma işlemini gerçekleştirir. -(GARBAGE COLLECTOR)-
            // using ile nesne zorla bellekden atılır. -(DISPOZE)- 
            // Burada direk veri tabanında sorgu işlemi yapıyor... (ihtiyaç olan veri alınır - büyük veri setlerinde kullanışlı)
            // Belirtilen değerden daha düşük fiyata sahip ürünleri getirir.
            using (ProductContext context = new ProductContext())
            {
                return context.Products.Where(p => p.Price <= price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            // Metod bittiği zaman işi biten nesneleri bellekden atma işlemini gerçekleştirir. -(GARBAGE COLLECTOR)-
            // using ile nesne zorla bellekden atılır. -(DISPOZE)- 
            // Burada direk veri tabanında sorgu işlemi yapıyor... (ihtiyaç olan veri alınır - büyük veri setlerinde kullanışlı)
            // Belirtilen iki değer arasında fiyata sahip ürünleri listeler.
            using (ProductContext context = new ProductContext())
            {
                return context.Products.Where(p => p.Price >= min && p.Price <= max).ToList();
            }
        }

        public List<Product> GetById(int id)
        {
            // Metod bittiği zaman işi biten nesneleri bellekden atma işlemini gerçekleştirir. -(GARBAGE COLLECTOR)-
            // using ile nesne zorla bellekden atılır. -(DISPOZE)- 
            // Belirtilen ID'ye sahip ürünü getirir.
            using (ProductContext context = new ProductContext())
            {
                var result = context.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }
        }

        public void Add(Product product)
        {
            using (ProductContext context = new ProductContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ProductContext context = new ProductContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ProductContext context = new ProductContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
