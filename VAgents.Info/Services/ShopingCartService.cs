namespace VAgents.Info.Services
{
    using Model;
    using Model.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Vagents.Info.Data;

    public partial class ShopingCartService
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        string ShoppingCartId { get; set; }
        public DateTime StartPromoPrice { get; set; }
        public DateTime EndPromoPrice { get; set; }

        public const string CartSessionKey = "CartId";

        public static ShopingCartService GetCart(HttpContextBase context)
        {
            var cart = new ShopingCartService();
            cart.ShoppingCartId = cart.GetCartId(context);
            return cart;
        }


        public static ShopingCartService GetCart(Controller controler)
        {
            return GetCart(controler.HttpContext);
        }

        public void AddToCart(Product product)
        {
            var cart = db.Carts.SingleOrDefault(c => c.CartId == ShoppingCartId && c.Product.Id == product.Id);
            if (cart == null)
            {
                cart = new Cart
                {
                    AlbumId = product.Id,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now,
                };
                db.Carts.Add(cart);
            }
            else
            {
                cart.Count++;
            }

            db.SaveChanges();
        }

        public int RemoveFromCart(int id)
        {
            var cartItem = db.Carts.Single(c => c.CartId == ShoppingCartId && c.RecordId == id);
            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                }

                else
                {
                    db.Carts.Remove(cartItem);
                }
            }

            return itemCount;
        }

        public void EmptyCart()
        {
            var cartItems = db.Carts.Where(c => c.CartId == ShoppingCartId);
            foreach (var cartItem in cartItems)
            {
                db.Carts.Remove(cartItem);
            }

            db.SaveChanges();
        }

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(c => c.CartId == ShoppingCartId).ToList();
        }

        public int GetCount()
        {
            int? count = (from cartItems in db.Carts
                          where cartItems.CartId == ShoppingCartId
                          select (int?)cartItems.Count).Sum();
            return count ?? 0;
        }
        public decimal GetTotal()
        {
            //if (db.Products.Where(x=>x.StartPromoPrice >= DateTime.Now) && db.Products.Where(x=>x.EndPromoPrice < DateTime.Now)
                
            //{
            ////    //get promo price
            //    decimal? totalInPromoTime = (from cartItems in db.Carts
            //                      where cartItems.CartId == ShoppingCartId
            //                      select (int?)cartItems.Count * cartItems.Product.PromoPrice).Sum();
            //    return totalInPromoTime ?? decimal.Zero;
            //}
             if(DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                decimal? totalWithPromoInFriday = (from cartItems in db.Carts
                                  where cartItems.CartId == ShoppingCartId
                                  select (int?)cartItems.Count * cartItems.Product.PromoPrice).Sum();
                return totalWithPromoInFriday ?? decimal.Zero;
            }

            //get promo price
            decimal? total = (from cartItems in db.Carts
                              where cartItems.CartId == ShoppingCartId
                              select (int?)cartItems.Count * cartItems.Product.Price).Sum();
            return total ?? decimal.Zero;

        }

        private string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();

                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }

            return context.Session[CartSessionKey].ToString();
        }

        public void MigrateCart(string userName)
        {
            var shoppingCart = db.Carts.Where(c => c.CartId == ShoppingCartId);

            foreach (Cart item in shoppingCart)
            {
                item.CartId = userName;
            }
            db.SaveChanges();
        }
    }
}