using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopiz
{
    interface ICart
    {
        /// <summary>
        /// This property gets the cart'id.
        /// </summary>
        public string Id
        {
            get;
        }

        /// <summary>
        /// This property gets the cart's name.
        /// </summary>
        public string Name
        {
            get;
        }

        /// <summary>
        /// This property gets the cart's items.
        /// </summary>
        public List<CartItem> CartItems
        {
            get;
        }

        /// <summary>
        /// This property gets the cart's balance (sum of item's unit price).
        /// </summary>
        public double Balance
        {
            get;
        }

        /// <summary>
        /// This property gets the cart's currency.
        /// </summary>
        string Currency
        {
            get;
        }

        void AddItems(List<CartItem> cartItems);
        public void Empty();
    }
}
