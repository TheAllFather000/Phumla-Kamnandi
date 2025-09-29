using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Phumla.Data;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace Phumla.Business
{
    public class GuestController
    {
        GuestDB gdb;
        Collection<Guest> guests;

        public Collection<Guest> Guests
        { get { return guests; } set { guests = value; } }

        public GuestController()
        {
            gdb = new GuestDB();
            guests = gdb.Guests;
        }

        public Guest Find(long id)
        {
            foreach (Guest gue in guests)
            {
                if (gue.ID == id) return gue;
            }
            return null;
        }
        public bool replaceGuest(Guest g)
        {
            bool success;
            for (int i = 0; i <Guests.Count;i++)
            {
                if (Guests[i].ID == g.ID)
                {
                    Guests[i] = g;
                    break;
                }
            }
            success = gdb.DataSetChange(g, DB.Operation.Edit);
            guests = gdb.Guests;
            return success;
        }
        public bool addNewGuest(Guest g)
        {
            
            bool success = gdb.DataSetChange(g, DB.Operation.Add);
            guests = gdb.Guests;
            return success;
        }

    }
}
