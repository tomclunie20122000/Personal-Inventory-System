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
            return getItems.load(query);
        }

        public void deleteItem(string value)
        {
            getItems.delete(value);
        }

        public string getTotalPrice(string user)
        {
            return getItems.calculate_price(user).ToString();
        }

        public DataTable updateSearch(string search)
        {
            return getItems.search(search);
        }

    }
}

