using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class GCLog
    {
        private string gid;
        private string eid;
        private DateTime date;
        public GCLog() { }

        public string GuestID
        { get { return gid; } set { gid = value; } } 
        public DateTime Date
        { get { return date; } set { date = value; } }

        public string EmployeeID
        {

            get { return eid; }
            set { eid = value; }
        }
        public GCLog(string gid, string eid)
        {
            this.gid = gid;
            this.eid = eid;
            date = DateTime.Now;
        }

        public GCLog(GCLog g)
        {
            gid = g.gid;
            eid = g.eid;
            date = g.date;
        }
       
    }
}
