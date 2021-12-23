using System;
using System.Collections.Generic;

namespace Shopiz
{
    /// <summary>
    /// This class is designed to be a shopping cart
    /// </summary>
    class Cart : ICart
    {
        #region private attributes
        #endregion private attributes

        #region public methods
        /// <summary>
        /// This constructor provides a Cart Object
        /// </summary>
        /// <param name="id">cart's unique identifier</param>
        /// <param name="name">cart's name</param>
        /// <param name="cartItems">collection of cart's items. If null, balance will be set to zero.</param>
        public Cart(string id, string name, List<CartItem> cartItems)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This property gets the cart'id.
        /// </summary>
        public string Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This property gets the cart's name.
        /// </summary>
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This property gets the cart's items.
        /// </summary>
        public List<CartItem> CartItems
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This property gets the cart's balance (sum of item's unit price).
        /// </summary>
        public double Balance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This property gets the cart's currency.
        /// </summary>
        public string Currency
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This method adds a list of cart item in the current cart.
        /// </summary>
        /// <param name="cartItemsToAdd">List of cart items to add</param>
        public void AddItems(List<CartItem> cartItemsToAdd)
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region private methods
        #endregion private methods
    }

    public class EmptyCartException : CartException { }
}
