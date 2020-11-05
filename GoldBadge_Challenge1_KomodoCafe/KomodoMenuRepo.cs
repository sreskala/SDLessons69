using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_Challenge1_KomodoCafe
{
    public class KomodoMenuRepo
    {
        //Private field for repo
        private List<KomodoMenu> _menuDirectory = new List<KomodoMenu>();

        //CRUD - Create. Read. Update. Delete

        //Create method - or add
        public bool AddItemToMenu(KomodoMenu menuItem)
        {

            int startingCount = _menuDirectory.Count;

            _menuDirectory.Add(menuItem);
            bool wasAdded = startingCount < _menuDirectory.Count ? true : false;

            return wasAdded;
        }

        //Read method - or get

        //Update method

        //Delete method
    }
}
