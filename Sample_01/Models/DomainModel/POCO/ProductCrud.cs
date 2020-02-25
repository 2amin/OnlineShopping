using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sample_01.Models.DomainModel.DTO.EF;

namespace Sample_01.Models.DomainModel.POCO
{
    public class ProductCrud
    {
        #region [-Ctor-]
        public ProductCrud()
        {

        }
        #endregion
        #region [-Tasks-]
        #region [-Insert(Product product)-]
        public void Insert(Product product)
        {
            using (var Context = new OnlineShoppingSampleEntities())
            {
                try
                {
                    Context.Product.Add(product);
                    Context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }

            }
        }
        #endregion
        #region [-Select()-]
        public List<Product> Select()
        {
            using (var Context = new OnlineShoppingSampleEntities())
            {
                try
                {
                    var q = Context.Product.ToList();
                    return q;

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }

            }
        }
        #endregion
        #region [-Delete(int id)-]
        public void Delete(int id)
        {
            using (var Context = new OnlineShoppingSampleEntities())
            {
                try
                {
                    var q = Context.Product.Find(id);
                    Context.Product.Remove(q);
                }
                catch (Exception)
                {

                    throw;
                }
                if (Context != null)
                {
                    Context.Dispose();
                }
            }
        }
        #endregion
        #region [-Update(Product product)
        public void Update(Product product)
        {
            using (var Context = new OnlineShoppingSampleEntities())
            {
                try
                {
                    var q = Context.Product.Find(product.Productid);
                    q = product;
                    Context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                if (Context != null)
                {
                    Context.Dispose();
                }

            }
        }
        #endregion
        #region [-Find(int id)-]
        public Product Find(int id)
        {
            using (var Context = new Models.DomainModel.DTO.EF.OnlineShoppingSampleEntities())
            {
                try
                {
                    var Product = Context.Product.Find(id);
                    return Product;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }

            }
        } 
        #endregion
        #endregion

    }
}