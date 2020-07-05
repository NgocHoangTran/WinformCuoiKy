using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProductWithCode.Models;

namespace TaskProductWithCode.Controller
{
    class ProductController
    {
        public static bool AddProduct(Product product)
        {
            try
            {
                using (var _context = new DBproductqrbarcodeEntities())
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }


        }
        public static List<Product> getlistProduct()
        {
            using (var _context = new DBproductqrbarcodeEntities())
            {
                var product = (from u in _context.Products
                               select u).ToList();
                return product;
            }
        }
        public static Product getProduct(string codebarqr)
        {
            using (var _context = new DBproductqrbarcodeEntities())
            {
                var product = (from u in _context.Products
                               where u.codeBarQR == codebarqr
                               select u).ToList();
                if (product.Count == 1)
                {
                    return product[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool DeleteProduct(Product product)
        {
            using (var _context = new DBproductqrbarcodeEntities())
            {
                var products = (from u in _context.Products
                                where u.codeBarQR == product.codeBarQR
                                select u).SingleOrDefault();
                _context.Products.Remove(products);
                _context.SaveChanges();
                return true;
            }
        }
        public static List<Product> getlistProduct(string productbarqrcode)
        {
            using (var _context = new DBproductqrbarcodeEntities())
            {
                var product = (from u in _context.Products.AsEnumerable()
                               where u.nameProduct.Contains(productbarqrcode)
                               select u
                        ).Select(x => new Product
                        {
                            codeBarQR = x.codeBarQR,
                            nameProduct = x.nameProduct,
                            Price = x.Price,
                            dateCreate = x.dateCreate,
                            Descriptions = x.Descriptions,
                            pathImage = x.pathImage
                        }).ToList();
                return product;
            }
        }
        public static bool UpdateProduct(Product product)
        {
            try
            {
                using (var _context = new DBproductqrbarcodeEntities())
                {
                    _context.Products.AddOrUpdate(product);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
