using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lab4
{
	public class ItemManager
	{
		public List<Item> _lstItems;

        public ItemManager()
        {
            _lstItems = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _lstItems.Add(item);
        }

        public void UpdateItem(int id, string newName)
        {
            var temp = _lstItems.FirstOrDefault(a => a.Id == id);

            if (temp != null)
            {
                temp.Name = newName;
            }
        }

        public void DeleteItem(int id)
        {
            _lstItems.RemoveAll(a => a.Id == id);
        }
    }
}
