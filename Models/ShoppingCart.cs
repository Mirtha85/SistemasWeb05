﻿using Microsoft.EntityFrameworkCore;

namespace SistemasWeb01.Models
{
    public class ShoppingCart : IShoppingCart
    {
            private readonly BethesdaPieShopDbContext _bethesdaPieShopDbContext;

            public string? ShoppingCartId { get; set; }

            public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

            private ShoppingCart(BethesdaPieShopDbContext bethesdaPieShopDbContext)
            {
                _bethesdaPieShopDbContext = bethesdaPieShopDbContext;
            }
            /*This method we didn't have on our interface, it is a static method
             * It will return me a fully created ShoppingCart
             * I am passing a services colletion
             * When the user visits the site this code is going to run and it's going to check if there is already
             * and ID called CartId available for the user.If not the will create a new GUID and restore the values as the CartId.
             * When the user is returning, we'll be able to find the existing CartId and we'll use that.
             */
            public static ShoppingCart GetCart(IServiceProvider services)
            {
                ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

                BethesdaPieShopDbContext context = services.GetService<BethesdaPieShopDbContext>() ?? throw new Exception("Error initializing");

                string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

                session?.SetString("CartId", cartId);

                return new ShoppingCart(context) { ShoppingCartId = cartId };
            }

            public void AddToCart(Pie pie)
            {
                var shoppingCartItem =
                        _bethesdaPieShopDbContext.ShoppingCartItems.SingleOrDefault(
                            s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);

                if (shoppingCartItem == null)
                {
                    shoppingCartItem = new ShoppingCartItem
                    {
                        ShoppingCartId = ShoppingCartId,
                        Pie = pie,
                        Amount = 1
                    };

                    _bethesdaPieShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
                }
                else
                {
                    shoppingCartItem.Amount++;
                }
                _bethesdaPieShopDbContext.SaveChanges();
            }

            public int RemoveFromCart(Pie pie)
            {
                var shoppingCartItem =
                        _bethesdaPieShopDbContext.ShoppingCartItems.SingleOrDefault(
                            s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);

                var localAmount = 0;

                if (shoppingCartItem != null)
                {
                    if (shoppingCartItem.Amount > 1)
                    {
                        shoppingCartItem.Amount--;
                        localAmount = shoppingCartItem.Amount;
                    }
                    else
                    {
                        _bethesdaPieShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                    }
                }

                _bethesdaPieShopDbContext.SaveChanges();

                return localAmount;
            }

            public List<ShoppingCartItem> GetShoppingCartItems()
            {
                return ShoppingCartItems ??=
                            _bethesdaPieShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                                .Include(s => s.Pie)
                                .ToList();
            }

            public void ClearCart()
            {
                var cartItems = _bethesdaPieShopDbContext
                    .ShoppingCartItems
                    .Where(cart => cart.ShoppingCartId == ShoppingCartId);

                _bethesdaPieShopDbContext.ShoppingCartItems.RemoveRange(cartItems);

                _bethesdaPieShopDbContext.SaveChanges();
            }

            public decimal GetShoppingCartTotal()
            {
                var total = _bethesdaPieShopDbContext.ShoppingCartItems
                    .Where(c => c.ShoppingCartId == ShoppingCartId)
                    .ToList() // force to handle it as C# object
                    .Select(c => c.Pie.Price * c.Amount).Sum();
                return total;
            }
    }
}
