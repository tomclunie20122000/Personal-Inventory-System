using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventorySystem
{
    internal class itemBLL
    {
        itemDAL getItems = new itemDAL();
        public DataTable GetItemsForUser(string query)
        {
            try
            {
                return getItems.load(query);
            }
            catch
            {
                throw;
            }
        }

        public void addItem(string currentUser, string name, string desc, string value, string quantity, string purchaseD, string retailer, string URL)
        {
            try
            {
                getItems.add(currentUser, name, desc, value, quantity, purchaseD, retailer, URL);
            }
            catch
            {
                throw;
            }
        }

        public void deleteItem(string value)
        {
            try
            {
                getItems.delete(value);
            }
            catch
            {
                throw;
            }            
        }

        public string getTotalPrice(string user)
        {
            try
            {
                return getItems.calculate_price(user).ToString();
            }
            catch
            {
                throw;
            }
        }

        public DataTable updateSearch(string search)
        {
            try
            {
                return getItems.search(search);
            }
            catch
            {
                throw;
            }
        }

    }
}

