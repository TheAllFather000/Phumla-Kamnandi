using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    public class Access
    {
        private long employeeid;
        private string password;
        public enum AccessLevel
        {
            Receptionist,
            Manager,
            Administrator,
            None
        }
        private AccessLevel level;

        public long EmployeeID
        { get { return employeeid; } set { employeeid = value; } }
        public string Password
        { get { return password; } set { password = value; } }
        public AccessLevel Level

        {get { return level; } set { level = value; }}
        public Access() { }

        public Access(long eid, string pword)
        {
            employeeid = eid;
            password = pword;
            level = AccessLevel.Receptionist;
        }
        public Access(long eid, string pword,  AccessLevel l)
        {
            employeeid = eid;
            password = pword;
            level = l;
        }
        public Access(Access a)
        {
            employeeid=a.employeeid;
            password = a.password;
            level = a.level;
        }
    }
}
