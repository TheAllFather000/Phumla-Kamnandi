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

        public Guest Find(string id)
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
            for (int i = 0; i < Guests.Count; i++)
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
        public bool removeGuest(string id)
        {
            foreach (Guest g in guests)
            {
                if (g.ID == id)
                {
                    guests.Remove(g);
                }
            }
            bool success =gdb.DeleteEntry(id, DB.Operation.Delete);
            guests = gdb.Guests;
            return success;
        }
        public bool checkIDExists(string id)
        {
            foreach (Guest g in guests)
            {
                if (g.ID == id) 
                    return true;
            }
            return false;

        }
        public bool checkPhoneNumberExists(string pNum)
        {
            foreach (Guest g in guests)
            {
                if (g.Phone ==pNum)
                    return true;
            }
            return false;
        }

         
    }
}
