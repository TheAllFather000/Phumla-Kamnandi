[33mcommit 32366d7063ccc7c547f347b93f1cd1c009f4add2[m[33m ([m[1;36mHEAD[m[33m -> [m[1;32mmain[m[33m)[m
Author: Ibrahim Sow <ibrahimsow367@gmail.com>
Date:   Fri Oct 17 02:01:54 2025 +0200

    report generation completed and implemented

[1mdiff --git a/Phumla/Business/GCLog.cs b/Phumla/Business/GCLog.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..a2c9156[m
[1m--- /dev/null[m
[1m+++ b/Phumla/Business/GCLog.cs[m
[36m@@ -0,0 +1,43 @@[m
[32m+[m[32m﻿using System;[m
[32m+[m[32musing System.Collections.Generic;[m
[32m+[m[32musing System.Data;[m
[32m+[m[32musing System.Linq;[m
[32m+[m[32musing System.Text;[m
[32m+[m[32musing System.Threading.Tasks;[m
[32m+[m
[32m+[m[32mnamespace Phumla.Business[m
[32m+[m[32m{[m
[32m+[m[32m    public class GCLog[m
[32m+[m[32m    {[m
[32m+[m[32m        private string gid;[m
[32m+[m[32m        private string eid;[m
[32m+[m[32m        private DateTime date;[m
[32m+[m[32m        public GCLog() { }[m
[32m+[m
[32m+[m[32m        public string GuestID[m
[32m+[m[32m        { get { return gid; } set { gid = value; } }[m[41m [m
[32m+[m[32m        public DateTime Date[m
[32m+[m[32m        { get { return date; } set { date = value; } }[m
[32m+[m
[32m+[m[32m        public string EmployeeID[m
[32m+[m[32m        {[m
[32m+[m
[32m+[m[32m            get { return eid; }[m
[32m+[m[32m            set { eid = value; }[m
[32m+[m[32m        }[m
[32m+[m[32m        public GCLog(string gid, string eid)[m
[32m+[m[32m        {[m
[32m+[m[32m            this.gid = gid;[m
[32m+[m[32m            this.eid = eid;[m
[32m+[m[32m            date = DateTime.Now;[m
[32m+[m[32m        }[m
[32m+[m
[32m+[m[32m        public GCLog(GCLog g)[m
[32m+[m[32m        {[m
[32m+[m[32m            gid = g.gid;[m
[32m+[m[32m            eid = g.eid;[m
[32m+[m[32m            date = g.date;[m
[32m+[m[32m        }[m
[32m+[m[41m       [m
[32m+[m[32m    }[m
[32m+[m[32m}[m
[1mdiff --git a/Phumla/Data/GuestCreationDB.cs b/Phumla/Data/GuestCreationDB.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..d4cb430[m
[1m--- /dev/null[m
[1m+++ b/Phumla/Data/GuestCreationDB.cs[m
[36m@@ -0,0 +1,68 @@[m
[32m+[m[32m﻿using Microsoft.VisualBasic;[m
[32m+[m[32musing Phumla.Business;[m
[32m+[m[32musing System;[m
[32m+[m[32musing System.Collections.Generic;[m
[32m+[m[32musing System.Data;[m
[32m+[m[32musing System.Linq;[m
[32m+[m[32musing System.Net.NetworkInformation;[m
[32m+[m[32musing System.Text;[m
[32m+[m[32musing System.Threading.Tasks;[m
[32m+[m
[32m+[m[32mnamespace Phumla.Data[m
[32m+[m[32m{[m
[32m+[m[32m    public class GuestCreationDB : DB[m
[32m+[m[32m    {[m
[32m+[m[32m        public const string particularyear = "SELECT employeeid AS EmployeeID, COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE YEAR(GuestCreationLog.date) = {0} Group by employeeid";[m
[32m+[m[32m        public const string before = "SELECT employeeid AS EmployeeID, COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE GuestCreationLog.date <'{0}' Group by employeeid";[m
[32m+[m[32m        public const string after = "SELECT employeeid AS EmployeeID , COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE GuestCreationLog.date >'{0}' Group by employeeid";[m
[32m+[m[32m        public const string between = "SELECT employeeid AS EmployeeID, COUNT(*) AS Total_Guest FROM GuestCreationLog WHERE GuestCreationLog.date >'{0}' AND GuestCreationLog.date < '{1}' Group by employeeid";[m
[32m+[m[32m        public GuestCreationDB()[m
[32m+[m[32m        {[m
[32m+[m[32m            Fill("Select * From GuestCreationLog", "GuestCreationLog");[m
[32m+[m[32m        }[m
[32m+[m
[32m+[m[32m        public void selectData(string selectCommand)[m
[32m+[m[32m        {[m
[32m+[m[32m            Fill(selectCommand, "GuestCreationLog");[m
[32m+[m[32m        }[m
[32m+[m[32m        public DataSet getDataSet()[m
[32m+[m[32m        {[m
[32m+[m[32m            return ds;[m
[32m+[m[32m        }[m
[32m+[m[32m        public bool newEntry(string id, string eid)[m
[32m+[m[32m        {[m
[32m+[m[32m            GCLog g = new GCLog(id, eid);[m
[32m+[m[32m            DataRow r = ds.Tables["GuestCreationLog"].NewRow();[m
[32m+[m[32m            return FillRow(r, g, "GuestCreationLog", Operation.Add);[m
[32m+[m[32m        }[m
[32m+[m
[32m+[m[32m        public void getYearData(string year)[m
[32m+[m[32m        {[m
[32m+[m[32m            string select = string.Format(particularyear, year);[m
[32m+[m[32m            Console.WriteLine(select);[m
[32m+[m
[32m+[m[32m            selectData(select);[m
[32m+[m[32m        }[m
[32m+[m[32m        public void getBefore(string period)[m
[32m+[m[32m        {[m
[32m+[m[32m            string select = string.Format(before, period);[m
[32m+[m[32m            Console.WriteLine(select);[m
[32m+[m[32m            selectData(select);[m
[32m+[m[32m        }[m
[32m+[m[32m        public void getAfter(string period)[m
[32m+[m[32m        {[m
[32m+[m[32m            string select = string.Format(after, period);[m
[32m+[m[32m            Console.WriteLine(select);[m
[32m+[m
[32m+[m[32m            selectData(select);[m
[32m+[m[32m        }[m
[32m+[m[32m        public void getBetween(string period, string period2)[m
[32m+[m[32m        {[m
[32m+[m[32m            string select = string.Format(between, period, period2);[m
[32m+[m[32m            Console.WriteLine(select);[m
[32m+[m
[32m+[m[32m            selectData(select);[m
[32m+[m[32m        }[m
[32m+[m[41m        [m
[32m+[m[32m    }[m
[32m+[m[32m}[m
[1mdiff --git a/Phumla/InsertGuestCreationLog.sql b/Phumla/InsertGuestCreationLog.sql[m
[1mnew file mode 100644[m
[1mindex 0000000..320bd2b[m
[1m--- /dev/null[m
[1m+++ b/Phumla/InsertGuestCreationLog.sql[m
[36m@@ -0,0 +1,300 @@[m
[32m+[m[32m﻿INSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8103268246185', '2025-03-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8609174153088', '2025-09-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '6107018759182', '2025-05-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5102094588188', '2024-12-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6412260221189', '2025-04-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '8509020713180', '2024-12-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5612310107080', '2025-01-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6004255228181', '2025-01-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5302064467183', '2024-11-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8102246986083', '2025-07-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110112, '7909057736186', '2025-05-21');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7708219627085', '2025-02-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6708307973184', '2024-11-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6007200734081', '2025-08-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110129, '8712218710081', '2025-05-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '5404014601181', '2025-04-11');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110126, '5909219277085', '2024-11-06');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9907037934185', '2025-08-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110140, '5103295343082', '2025-03-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8905079110088', '2025-08-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '8104017029184', '2025-04-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6311174214187', '2025-07-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6209084509183', '2025-04-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '8210044835088', '2025-06-12');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '8607066448184', '2025-03-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '8404171734085', '2025-06-06');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '5111205098089', '2025-05-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '9912017048085', '2025-06-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '0204086142186', '2025-04-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '8611282697189', '2024-12-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '7412127438186', '2025-03-31');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6611300033183', '2025-06-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8601034093188', '2025-01-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7604160705082', '2025-04-21');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5010269354087', '2025-02-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '8607123337081', '2025-03-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9903277806183', '2024-11-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '7109169037088', '2025-10-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6005264659184', '2025-10-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5610115015184', '2025-04-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6509168688087', '2025-05-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '0009063991081', '2025-03-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '7109080360080', '2025-05-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110120, '7509179918086', '2025-09-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7310115102181', '2025-03-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '5012183441189', '2025-03-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110127, '5205012268189', '2025-07-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5205181731084', '2025-06-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5809104713088', '2025-01-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '8909284985180', '2025-05-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8708119083188', '2025-02-16');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5310049646080', '2025-07-24');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9907307255082', '2024-12-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6306210354086', '2025-01-11');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '5810312260186', '2024-12-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9301067068187', '2025-04-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '6109010641087', '2025-08-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110124, '8103112305083', '2025-01-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '0512236643082', '2025-02-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110137, '6602152885088', '2024-11-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '8702252524087', '2025-09-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0510250978087', '2025-09-21');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0508116523082', '2025-02-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6305259796085', '2024-12-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6707075166183', '2025-04-20');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '8411177018183', '2024-11-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '8308316592187', '2025-03-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5308261766189', '2025-06-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '9708095157183', '2025-02-20');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0106307724083', '2025-03-16');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '0311121395080', '2024-12-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8405280801085', '2025-09-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8303220487180', '2024-11-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '9604027086183', '2025-08-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8912087279180', '2025-01-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '6809241712185', '2025-09-24');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '9302150611084', '2025-08-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9611204248087', '2025-08-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5609096036082', '2025-08-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110117, '0103181562086', '2025-06-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5407234398181', '2025-03-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5705234143185', '2025-09-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8008110713088', '2025-03-16');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5411036432184', '2025-05-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110131, '5709115180189', '2025-03-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5508310097181', '2025-04-11');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8312163226083', '2025-01-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5711232205080', '2024-12-24');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5008299768087', '2025-07-21');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5902145341086', '2024-11-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '9403309159183', '2025-08-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '7001216383185', '2025-10-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '7610240145185', '2025-08-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110117, '7406251856189', '2025-10-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8409057238085', '2025-02-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110126, '7208215625186', '2024-12-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '8406218517180', '2025-06-16');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '0212308015084', '2025-06-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '8011117696183', '2025-04-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '0310314473089', '2025-07-31');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '0001037210084', '2024-10-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8410261193081', '2025-03-21');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7906284334087', '2024-12-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '6903090067185', '2024-11-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6304222953185', '2025-08-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5302197263087', '2025-08-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110118, '5007121596084', '2025-04-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9707096070088', '2025-04-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '6901288160186', '2025-01-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6407226585082', '2025-08-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6209269035086', '2025-06-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5812187541184', '2025-01-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6403215515180', '2025-03-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '7003048190181', '2025-05-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '5508056899083', '2025-07-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5006176269080', '2025-08-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '7001285149185', '2025-01-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7907081192180', '2025-03-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5608296247185', '2025-03-20');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '0111198517080', '2025-07-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110118, '8607081699186', '2025-03-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5106204767180', '2025-03-24');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '0209280936086', '2024-12-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7801291114183', '2025-02-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9104077557187', '2025-05-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '5308231903188', '2024-12-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '0103218313184', '2024-11-24');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '9403196003184', '2025-07-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7004058483186', '2024-12-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '5203140164081', '2024-12-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110112, '9309136427183', '2024-12-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9106091668088', '2024-12-11');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0005295433181', '2025-09-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '8503286457081', '2025-08-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6311115341085', '2024-11-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5310119860083', '2025-03-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '6303283055081', '2025-07-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8205116909189', '2024-10-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110127, '8805214326187', '2025-01-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110120, '9612146099182', '2025-07-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0410110529184', '2025-04-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5707177376182', '2025-06-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9808032433085', '2025-05-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5807270216086', '2024-11-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5807243376081', '2025-10-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6702106444086', '2025-08-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '6510262686180', '2025-02-16');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '8308070284087', '2025-07-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5009194505185', '2025-07-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '0310111245182', '2025-08-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6308045996189', '2024-11-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7808115558085', '2025-08-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5801121744081', '2025-06-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5304092779187', '2025-03-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '7307095443084', '2024-11-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110136, '0502123971081', '2025-05-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5501197786087', '2025-06-12');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5811185750087', '2025-03-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '5509092378082', '2025-03-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5709194782181', '2025-03-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '9411190475089', '2025-09-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '6804081471183', '2025-04-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '7512279624185', '2024-10-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8005256283088', '2025-04-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110135, '7105250705181', '2025-05-31');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6209157230088', '2025-02-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7202225168084', '2025-09-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6201128759180', '2025-07-12');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '5109198961182', '2025-07-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110118, '9311171864088', '2025-07-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0401148274088', '2025-06-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '0209277369187', '2025-05-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6411053768084', '2025-01-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8907259264081', '2025-08-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9003319263186', '2025-08-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9012188738089', '2025-05-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110140, '9208090156081', '2025-01-11');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9807139970086', '2025-04-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '7212032409083', '2025-09-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110130, '5002122959189', '2025-04-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9808225697087', '2025-05-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '7209199298185', '2025-01-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '7011056881183', '2024-11-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5008076170086', '2025-05-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8906059126181', '2025-01-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7607070325081', '2025-10-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9509175006188', '2024-11-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8410196580188', '2025-05-06');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '8708314985187', '2025-07-12');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8812276212187', '2025-03-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9503230392085', '2024-12-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '7309168527188', '2025-06-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '9912043574088', '2025-01-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '0411159909189', '2025-09-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7508287184186', '2025-06-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110125, '0203050640082', '2025-04-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7806251815182', '2025-06-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '9503230883189', '2025-02-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8603192407081', '2024-12-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0007027659081', '2025-09-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9709241444080', '2024-12-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '7906041555087', '2025-09-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5611164009189', '2024-12-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6206265366185', '2025-07-11');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '7306183428089', '2025-03-30');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9104249854081', '2025-07-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5611105538083', '2024-11-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '5904222553086', '2025-04-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110138, '5004012445181', '2025-01-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110126, '9806058720183', '2025-08-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '8106236554080', '2025-04-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '9409278589084', '2024-10-20');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110118, '8212108918083', '2025-10-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0302143011081', '2025-08-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '8106022856184', '2025-02-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '6603311572083', '2024-10-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6510214593085', '2024-12-24');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '8505312968181', '2025-02-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '9302238383086', '2025-07-14');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8003262687089', '2025-07-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6610115668085', '2025-07-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0403049675181', '2024-11-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '9503025695088', '2025-06-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0406181679082', '2025-07-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110117, '6507214197083', '2025-08-20');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110123, '5503080134086', '2025-01-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '9804208548189', '2024-10-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '8510284307084', '2025-04-06');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7502190337085', '2025-08-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '8110032209186', '2025-01-24');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0312242089180', '2025-03-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0510181934188', '2025-04-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '0509163752180', '2024-12-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9707135771082', '2025-07-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7901056586087', '2025-01-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '7508147262083', '2025-07-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6111286551189', '2025-09-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8510238282187', '2025-01-12');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7607170730181', '2025-02-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5010129630080', '2025-08-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9603071209184', '2025-01-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110117, '8805105184188', '2025-07-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110124, '0102077830083', '2025-08-21');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '9508312309186', '2025-07-06');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110119, '8208232544086', '2025-01-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9210215291180', '2024-12-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9010139077180', '2024-11-01');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9303032655182', '2025-10-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '6708313512085', '2025-05-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5502266986188', '2025-09-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110112, '8003274786184', '2024-11-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '7405284423180', '2025-05-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '7708253966081', '2025-03-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '8208182456085', '2024-12-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6911075924081', '2025-03-20');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '8802196424187', '2025-05-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5809197514080', '2024-10-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '9807292578188', '2024-12-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9702282435183', '2024-12-21');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '0404096363182', '2025-02-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6404036771082', '2025-07-31');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6911152256083', '2025-03-23');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '0411100293183', '2024-12-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110139, '9205202219189', '2025-09-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110114, '6806167948081', '2025-02-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6003266319086', '2024-11-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9608159466185', '2025-01-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '7611059700189', '2024-12-09');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '7604098185085', '2025-09-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '5812274778186', '2025-02-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '5703152164189', '2024-10-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110127, '0305147038080', '2025-06-03');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110140, '7807244723085', '2024-10-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110124, '5205292646087', '2025-05-10');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '0303206490183', '2025-01-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6808290507181', '2025-02-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '8410096301183', '2025-01-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6407118267080', '2025-09-11');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8304102981180', '2025-04-16');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110121, '9103187503187', '2025-01-06');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '9808300689088', '2025-07-16');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '9809275291088', '2024-12-27');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8803015835189', '2025-07-26');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110133, '5503272843183', '2024-10-19');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '0109301827088', '2025-09-13');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '8012251344086', '2025-04-04');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110122, '9301220371188', '2025-04-15');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110132, '8410019361186', '2025-02-05');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110134, '6306300049189', '2024-12-22');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110116, '9712253310188', '2025-08-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0212015574184', '2025-03-08');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '6904248787081', '2025-05-17');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110128, '8604176429082', '2024-10-29');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110111, '0205181464083', '2025-06-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '6408127682185', '2024-12-28');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110113, '7812124990089', '2025-04-25');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110112, '0403020266187', '2025-10-07');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110128, '7008246574080', '2025-04-02');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110115, '7202101040181', '2024-10-18');[m
[32m+[m[32mINSERT INTO GuestCreationLog (employeeid, guestid, date) VALUES (110118, '9004230219180', '2024-10-20');[m
\ No newline at end of file[m
[1mdiff --git a/Phumla/bin/Debug/Phumla.exe b/Phumla/bin/Debug/Phumla.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..0b123b2[m
Binary files /dev/null and b/Phumla/bin/Debug/Phumla.exe differ
[1mdiff --git a/Phumla/bin/Debug/Phumla.exe.config b/Phumla/bin/Debug/Phumla.exe.config[m
[1mnew file mode 100644[m
[1mindex 0000000..9ab6252[m
[1m--- /dev/null[m
[1m+++ b/Phumla/bin/Debug/Phumla.exe.config[m
[36m@@ -0,0 +1,18 @@[m
[32m+[m[32m<?xml version="1.0" encoding="utf-8"?>[m
[32m+[m[32m<configuration>[m
[32m+[m[32m    <configSections>[m
[32m+[m[32m    </configSections>[m
[32m+[m[32m    <connectionStrings>[m
[32m+[m[32m  <add name="Phumla.Properties.Settings.PKDatabaseConnectionString"[m
[32m+[m[32m       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;[m
[32m+[m[32m                         AttachDbFilename=|DataDirectory|\App_Data\PKDatabase.mdf;[m
[32m+[m[32m                         Integrated Security=True;[m
[32m+[m[32m                         Connect Timeout=30;[m
[32m+[m[32m                         Encrypt=False;[m
[32m+[m[32m                         TrustServerCertificate=True;"[m
[32m+[m[32m       providerName="System.Data.SqlClient" />[m
[32m+[m[32m</connectionStrings>[m
[32m+[m[32m    <startup>[m[41m [m
[32m+[m[32m        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8"/>[m
[32m+[m[32m    </startup>[m
[32m+[m[32m</configuration>[m
[1mdiff --git a/Phumla/bin/Debug/Phumla.pdb b/Phumla/bin/Debug/Phumla.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..6a79539[m
Binary files /dev/null and b/Phumla/bin/Debug/Phumla.pdb differ
[1mdiff --git a/Phumla/bin/Debug/ReaLTaiizor.dll b/Phumla/bin/Debug/ReaLTaiizor.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..74af7d7[m
Binary files /dev/null and b/Phumla/bin/Debug/ReaLTaiizor.dll differ
[1mdiff --git a/Phumla/bin/Debug/ReaLTaiizor.xml b/Phumla/bin/Debug/ReaLTaiizor.xml[m
[1mnew file mode 100644[m
[1mindex 0000000..6732f61[m
[1m--- /dev/null[m
[1m+++ b/Phumla/bin/Debug/ReaLTaiizor.xml[m
[36m@@ -0,0 +1,3041 @@[m
[32m+[m[32m<?xml version="1.0"?>[m
[32m+[m[32m<doc>[m
[32m+[m[32m    <assembly>[m
[32m+[m[32m        <name>ReaLTaiizor</name>[m
[32m+[m[32m    </assembly>[m
[32m+[m[32m    <members>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Child.Crown.CrownDialog.components">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Required designer variable.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Child.Crown.CrownDialog.Dispose(System.Boolean)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Clean up any resources being used.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Child.Crown.CrownDialog.InitializeComponent">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Required method for Designer support - do not modify[m
[32m+[m[32m            the contents of this method with the code editor.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Controls.MaterialButton.Depth">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Gets or sets the Depth[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Controls.MaterialButton.SkinManager">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Gets the SkinManager[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Controls.MaterialButton.MouseState">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Gets or sets the MouseState[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Controls.MaterialButton._textSize">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the _textSize[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Controls.MaterialButton._icon">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the _icon[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.MaterialButton.#ctor">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Initializes a new instance of the <see cref="T:ReaLTaiizor.Controls.MaterialButton"/> class.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Controls.MaterialButton.Text">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Gets or sets the Text[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.MaterialButton.OnPaint(System.Windows.Forms.PaintEventArgs)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The OnPaint[m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="pevent">The pevent<see cref="T:System.Windows.Forms.PaintEventArgs"/></param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.MaterialButton.GetPreferredSize">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The GetPreferredSize[m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <returns>The <see cref="T:System.Drawing.Size"/></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.MaterialButton.GetPreferredSize(System.Drawing.Size)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The GetPreferredSize[m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="proposedSize">The proposedSize<see cref="T:System.Drawing.Size"/></param>[m
[32m+[m[32m            <returns>The <see cref="T:System.Drawing.Size"/></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.MaterialButton.OnCreateControl">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The OnCreateControl[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.MetroButton.ApplyTheme(ReaLTaiizor.Enum.Metro.Style)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Gets or sets the style provided by the user.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="style">The Style.</param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Controls.NightButton.DialogResult">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Controls.MetroLabel.BackColor">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Gets or sets the form BackColor.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Controls.CrownMessageBox.components">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Required designer variable.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.CrownMessageBox.Dispose(System.Boolean)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Clean up any resources being used.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.CrownMessageBox.InitializeComponent">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Required method for Designer support - do not modify[m
[32m+[m[32m            the contents of this method with the code editor.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Controls.ForeverNotification.W">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            How to use: ForeverNotification.ShowControl(Kind, String, Interval)[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.HopeNotify.ShowAlertBox(ReaLTaiizor.Controls.HopeNotify.AlertType,System.String,System.Int32)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            How to use: HopeNotify.ShowAlertBox(Type, String, Interval)[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Controls.CyberColorPicker.components">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.CyberColorPicker.Dispose(System.Boolean)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="disposing"></param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Controls.CyberColorPicker.InitializeComponent">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NULL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NULL message performs no operation. An application sends the WM_NULL message if it wants to post a message that the recipient window will ignore.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CREATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CREATE message is sent when an application requests that a window be created by calling the CreateWindowEx or CreateWindow function. (The message is sent before the function returns.) The window procedure of the new window receives this message after the window is created, but before the window becomes visible.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DESTROY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_DESTROY message is sent when a window is being destroyed. It is sent to the window procedure of the window being destroyed after the window is removed from the screen.[m[41m [m
[32m+[m[32m            This message is sent first to the window being destroyed and then to the child windows (if any) as they are destroyed. During the processing of the message, it can be assumed that all child windows still exist.[m
[32m+[m[32m            /// </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOVE message is sent after a window has been moved.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SIZE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SIZE message is sent to a window after its size has changed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ACTIVATE message is sent to both the window being activated and the window being deactivated. If the windows use the same input queue, the message is sent synchronously, first to the window procedure of the top-level window being deactivated, then to the window procedure of the top-level window being activated. If the windows use different input queues, the message is sent asynchronously, so the window is activated immediately.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETFOCUS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SETFOCUS message is sent to a window after it has gained the keyboard focus.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.KILLFOCUS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_KILLFOCUS message is sent to a window immediately before it loses the keyboard focus.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ENABLE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ENABLE message is sent when an application changes the enabled state of a window. It is sent to the window whose enabled state is changing. This message is sent before the EnableWindow function returns, but after the enabled state (WS_DISABLED style bit) of the window has changed.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETREDRAW">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_SETREDRAW message to a window to allow changes in that window to be redrawn or to prevent changes in that window from being redrawn.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETTEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_SETTEXT message to set the text of a window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETTEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_GETTEXT message to copy the text that corresponds to a window into a buffer provided by the caller.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETTEXTLENGTH">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_GETTEXTLENGTH message to determine the length, in characters, of the text associated with a window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PAINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_PAINT message is sent when the system or another application makes a request to paint a portion of an application's window. The message is sent when the UpdateWindow or RedrawWindow function is called, or by the DispatchMessage function when the application obtains a WM_PAINT message by using the GetMessage or PeekMessage function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CLOSE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CLOSE message is sent as a signal that a window or an application should terminate.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.QUERYENDSESSION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_QUERYENDSESSION message is sent when the user chooses to end the session or when an application calls one of the system shutdown functions. If any application returns zero, the session is not ended. The system stops sending WM_QUERYENDSESSION messages as soon as one application returns zero.[m
[32m+[m[32m            After processing this message, the system sends the WM_ENDSESSION message with the wParam parameter set to the results of the WM_QUERYENDSESSION message.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.QUERYOPEN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_QUERYOPEN message is sent to an icon when the user requests that the window be restored to its previous size and position.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ENDSESSION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ENDSESSION message is sent to an application after the system processes the results of the WM_QUERYENDSESSION message. The WM_ENDSESSION message informs the application whether the session is ending.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.QUIT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_QUIT message indicates a request to terminate an application and is generated when the application calls the PostQuitMessage function. It causes the GetMessage function to return zero.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ERASEBKGND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ERASEBKGND message is sent when the window background must be erased (for example, when a window is resized). The message is sent to prepare an invalidated portion of a window for painting.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYSCOLORCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            This message is sent to all top-level windows when a change is made to a system color setting.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SHOWWINDOW">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SHOWWINDOW message is sent to a window when the window is about to be hidden or shown.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.WININICHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo function sends this message after an application uses the function to change a setting in WIN.INI.[m
[32m+[m[32m            Note  The WM_WININICHANGE message is provided only for compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETTINGCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo function sends this message after an application uses the function to change a setting in WIN.INI.[m
[32m+[m[32m            Note  The WM_WININICHANGE message is provided only for compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DEVMODECHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_DEVMODECHANGE message is sent to all top-level windows whenever the user changes device-mode settings.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ACTIVATEAPP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ACTIVATEAPP message is sent when a window belonging to a different application than the active window is about to be activated. The message is sent to the application whose window is being activated and to the application whose window is being deactivated.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.FONTCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_FONTCHANGE message to all top-level windows in the system after changing the pool of font resources.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.TIMECHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            A message that is sent whenever there is a change in the system time.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CANCELMODE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CANCELMODE message is sent to cancel certain modes, such as mouse capture. For example, the system sends this message to the active window when a dialog box or message box is displayed. Certain functions also send this message explicitly to the specified window regardless of whether it is the active window. For example, the EnableWindow function sends this message when disabling the specified window.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETCURSOR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SETCURSOR message is sent to a window if the mouse causes the cursor to move within a window and mouse input is not captured.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSEACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOUSEACTIVATE message is sent when the cursor is in an inactive window and the user presses a mouse button. The parent window receives this message only if the child window passes it to the DefWindowProc function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CHILDACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CHILDACTIVATE message is sent to a child window when the user clicks the window's title bar or when the window is activated, moved, or sized.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.QUEUESYNC">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_QUEUESYNC message is sent by a computer-based training (CBT) application to separate user-input messages from other messages sent through the WH_JOURNALPLAYBACK Hook procedure.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETMINMAXINFO">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_GETMINMAXINFO message is sent to a window when the size or position of the window is about to change. An application can use this message to override the window's default maximized size and position, or its default minimum or maximum tracking size.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PAINTICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Windows NT 3.51 and earlier: The WM_PAINTICON message is sent to a minimized window when the icon is to be painted. This message is not sent by newer versions of Microsoft Windows, except in unusual circumstances explained in the Remarks.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ICONERASEBKGND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Windows NT 3.51 and earlier: The WM_ICONERASEBKGND message is sent to a minimized window when the background of the icon must be filled before painting the icon. A window receives this message only if a class icon is defined for the window; otherwise, WM_ERASEBKGND is sent. This message is not sent by newer versions of Windows.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NEXTDLGCTL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NEXTDLGCTL message is sent to a dialog box procedure to set the keyboard focus to a different control in the dialog box.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SPOOLERSTATUS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SPOOLERSTATUS message is sent from Print Manager whenever a job is added to or removed from the Print Manager queue.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DRAWITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_DRAWITEM message is sent to the parent window of an owner-drawn button, combo box, list box, or menu when a visual aspect of the button, combo box, list box, or menu has changed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MEASUREITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MEASUREITEM message is sent to the owner window of a combo box, list box, list view control, or menu item when the control or menu is created.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DELETEITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to the owner of a list box or combo box when the list box or combo box is destroyed or when items are removed by the LB_DELETESTRING, LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT message. The system sends a WM_DELETEITEM message for each deleted item. The system sends the WM_DELETEITEM message for any deleted list box or combo box item with nonzero item data.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.VKEYTOITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_KEYDOWN message.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CHARTOITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_CHAR message.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETFONT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_SETFONT message to specify the font that a control is to use when drawing text.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETFONT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_GETFONT message to a control to retrieve the font with which the control is currently drawing its text.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETHOTKEY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_SETHOTKEY message to a window to associate a hot key with the window. When the user presses the hot key, the system activates the window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETHOTKEY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_GETHOTKEY message to determine the hot key associated with a window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.QUERYDRAGICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_QUERYDRAGICON message is sent to a minimized (iconic) window. The window is about to be dragged by the user but does not have an icon defined for its class. An application can return a handle to an icon or cursor. The system displays this cursor or icon while the user drags the icon.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.COMPAREITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The system sends the WM_COMPAREITEM message to determine the relative position of a new item in the sorted list of an owner-drawn combo box or list box. Whenever the application adds a new item, the system sends this message to the owner of a combo box or list box created with the CBS_SORT or LBS_SORT style.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETOBJECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Active Accessibility sends the WM_GETOBJECT message to obtain information about an accessible object contained in a server application.[m[41m [m
[32m+[m[32m            Applications never send this message directly. It is sent only by Active Accessibility in response to calls to AccessibleObjectFromPoint, AccessibleObjectFromEvent, or AccessibleObjectFromWindow. However, server applications handle this message.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.COMPACTING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_COMPACTING message is sent to all top-level windows when the system detects more than 12.5 percent of system time over a 30- to 60-second interval is being spent compacting memory. This indicates that system memory is low.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.COMMNOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_COMMNOTIFY is Obsolete for Win32-Based Applications[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.WINDOWPOSCHANGING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_WINDOWPOSCHANGING message is sent to a window whose size, position, or place in the Z order is about to change as a result of a call to the SetWindowPos function or another window-management function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.WINDOWPOSCHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_WINDOWPOSCHANGED message is sent to a window whose size, position, or place in the Z order has changed as a result of a call to the SetWindowPos function or another window-management function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.POWER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Notifies applications that the system, typically a battery-powered personal computer, is about to enter a suspended mode.[m
[32m+[m[32m            Use: POWERBROADCAST[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.COPYDATA">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_COPYDATA message to pass data to another application.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CANCELJOURNAL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CANCELJOURNAL message is posted to an application when a user cancels the application's journaling activities. The message is posted with a NULL window handle.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent by a common control to its parent window when an event has occurred or the control requires some information.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.INPUTLANGCHANGEREQUEST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_INPUTLANGCHANGEREQUEST message is posted to the window with the focus when the user chooses a new input language, either with the hotkey (specified in the Keyboard control panel application) or from the indicator on the system taskbar. An application can accept the change by passing the message to the DefWindowProc function or reject the change (and prevent it from taking place) by returning immediately.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.INPUTLANGCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_INPUTLANGCHANGE message is sent to the topmost affected window after an application's input language has been changed. You should make any application-specific settings and pass the message to the DefWindowProc function, which passes the message to all first-level child windows. These child windows can pass the message to DefWindowProc to have it pass the message to their child windows, and so on.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.TCARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application that has initiated a training card with Microsoft Windows Help. The message informs the application when the user clicks an authorable button. An application initiates a training card by specifying the HELP_TCARD command in a call to the WinHelp function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HELP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Indicates that the user pressed the F1 key. If a menu is active when F1 is pressed, WM_HELP is sent to the window associated with the menu; otherwise, WM_HELP is sent to the window that has the keyboard focus. If no window has the keyboard focus, WM_HELP is sent to the currently active window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.USERCHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_USERCHANGED message is sent to all windows after the user has logged on or off. When the user logs on or off, the system updates the user-specific settings. The system sends this message immediately after updating the settings.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NOTIFYFORMAT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Determines if a window accepts ANSI or Unicode structures in the WM_NOTIFY notification message. WM_NOTIFYFORMAT messages are sent from a common control to its parent window and from the parent window to the common control.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CONTEXTMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CONTEXTMENU message notifies a window that the user clicked the right mouse button (right-clicked) in the window.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.STYLECHANGING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_STYLECHANGING message is sent to a window when the SetWindowLong function is about to change one or more of the window's styles.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.STYLECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_STYLECHANGED message is sent to a window after the SetWindowLong function has changed one or more of the window's styles[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DISPLAYCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_DISPLAYCHANGE message is sent to all windows when the display resolution has changed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_GETICON message is sent to a window to retrieve a handle to the large or small icon associated with a window. The system displays the large icon in the ALT+TAB dialog, and the small icon in the window caption.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SETICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_SETICON message to associate a new large or small icon with a window. The system displays the large icon in the ALT+TAB dialog box, and the small icon in the window caption.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCCREATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCCREATE message is sent prior to the WM_CREATE message when a window is first created.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCDESTROY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCDESTROY message informs a window that its nonclient area is being destroyed. The DestroyWindow function sends the WM_NCDESTROY message to the window following the WM_DESTROY message. WM_DESTROY is used to free the allocated memory object associated with the window.[m[41m [m
[32m+[m[32m            The WM_NCDESTROY message is sent after the child windows have been destroyed. In contrast, WM_DESTROY is sent before the child windows are destroyed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCCALCSIZE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCCALCSIZE message is sent when the size and position of a window's client area must be calculated. By processing this message, an application can control the content of the window's client area when the size or position of the window changes.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCHITTEST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCHITTEST message is sent to a window when the cursor moves, or when a mouse button is pressed or released. If the mouse is not captured, the message is sent to the window beneath the cursor. Otherwise, the message is sent to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCPAINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCPAINT message is sent to a window when its frame must be painted.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCACTIVATE message is sent to a window when its nonclient area needs to be changed to indicate an active or inactive state.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETDLGCODE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_GETDLGCODE message is sent to the window procedure associated with a control. By default, the system handles all keyboard input to the control; the system interprets certain types of keyboard input as dialog box navigation keys. To override this default behavior, the control can respond to the WM_GETDLGCODE message to indicate the types of input it wants to process itself.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYNCPAINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SYNCPAINT message is used to synchronize painting while avoiding linking independent GUI threads.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCMOUSEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCMOUSEMOVE message is posted to a window when the cursor is moved within the nonclient area of the window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCLBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCLBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCLBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCLBUTTONUP message is posted when the user releases the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCLBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCLBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCRBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCRBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCRBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCRBUTTONUP message is posted when the user releases the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCRBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCRBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCMBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCMBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCMBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCMBUTTONUP message is posted when the user releases the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCMBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCMBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCXBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCXBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCXBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCXBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCXBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCXBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.INPUT_DEVICE_CHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_INPUT_DEVICE_CHANGE message is sent to the window that registered to receive raw input. A window receives this message through its WindowProc function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.INPUT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_INPUT message is sent to the window that is getting raw input.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.KEYFIRST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            This message filters for keyboard messages.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.KEYDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_KEYDOWN message is posted to the window with the keyboard focus when a nonsystem key is pressed. A nonsystem key is a key that is pressed when the ALT key is not pressed.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.KEYUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_KEYUP message is posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key that is pressed when the ALT key is not pressed, or a keyboard key that is pressed when a window has the keyboard focus.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. The WM_CHAR message contains the character code of the key that was pressed.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DEADCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_DEADCHAR message is posted to the window with the keyboard focus when a WM_KEYUP message is translated by the TranslateMessage function. WM_DEADCHAR specifies a character code generated by a dead key. A dead key is a key that generates a character, such as the umlaut (double-dot), that is combined with another character to form a composite character. For example, the umlaut-O character (Ö) is generated by typing the dead key for the umlaut character, and then typing the O key.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYSKEYDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SYSKEYDOWN message is posted to the window with the keyboard focus when the user presses the F10 key (which activates the menu bar) or holds down the ALT key and then presses another key. It also occurs when no window currently has the keyboard focus; in this case, the WM_SYSKEYDOWN message is sent to the active window. The window that receives the message can distinguish between these two contexts by checking the context code in the lParam parameter.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYSKEYUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SYSKEYUP message is posted to the window with the keyboard focus when the user releases a key that was pressed while the ALT key was held down. It also occurs when no window currently has the keyboard focus; in this case, the WM_SYSKEYUP message is sent to the active window. The window that receives the message can distinguish between these two contexts by checking the context code in the lParam parameter.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYSCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SYSCHAR message is posted to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. It specifies the character code of a system character key — that is, a character key that is pressed while the ALT key is down.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYSDEADCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SYSDEADCHAR message is sent to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. WM_SYSDEADCHAR specifies the character code of a system dead key — that is, a dead key that is pressed while holding down the ALT key.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.UNICHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_UNICHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. The WM_UNICHAR message contains the character code of the key that was pressed.[m[41m [m
[32m+[m[32m            The WM_UNICHAR message is equivalent to WM_CHAR, but it uses Unicode Transformation Format (UTF)-32, whereas WM_CHAR uses UTF-16. It is designed to send or post Unicode characters to ANSI windows and it can can handle Unicode Supplementary Plane characters.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.KEYLAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            This message filters for keyboard messages.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_STARTCOMPOSITION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent immediately before the IME generates the composition string as a result of a keystroke. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_ENDCOMPOSITION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application when the IME ends composition. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_COMPOSITION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application when the IME changes composition status as a result of a keystroke. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.INITDIALOG">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_INITDIALOG message is sent to the dialog box procedure immediately before a dialog box is displayed. Dialog box procedures typically use this message to initialize controls and carry out any other initialization tasks that affect the appearance of the dialog box.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.COMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_COMMAND message is sent when the user selects a command item from a menu, when a control sends a notification message to its parent window, or when an accelerator keystroke is translated.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYSCOMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            A window receives this message when the user chooses a command from the Window menu, clicks the maximize button, minimize button, restore button, close button, or moves the form. You can stop the form from moving by filtering this out.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.TIMER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_TIMER message is posted to the installing thread's message queue when a timer expires. The message is posted by the GetMessage or PeekMessage function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSCROLL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_HSCROLL message is sent to a window when a scroll event occurs in the window's standard horizontal scroll bar. This message is also sent to the owner of a horizontal scroll bar control when a scroll event occurs in the control.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.VSCROLL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_VSCROLL message is sent to a window when a scroll event occurs in the window's standard vertical scroll bar. This message is also sent to the owner of a vertical scroll bar control when a scroll event occurs in the control.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.INITMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_INITMENU message is sent when a menu is about to become active. It occurs when the user clicks an item on the menu bar or presses a menu key. This allows the application to modify the menu before it is displayed.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.INITMENUPOPUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_INITMENUPOPUP message is sent when a drop-down menu or submenu is about to become active. This allows an application to modify the menu before it is displayed, without changing the entire menu.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MENUSELECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MENUSELECT message is sent to a menu's owner window when the user selects a menu item.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MENUCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MENUCHAR message is sent when a menu is active and the user presses a key that does not correspond to any mnemonic or accelerator key. This message is sent to the window that owns the menu.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ENTERIDLE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ENTERIDLE message is sent to the owner window of a modal dialog box or menu that is entering an idle state. A modal dialog box or menu enters an idle state when no messages are waiting in its queue after it has processed one or more previous messages.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MENURBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MENURBUTTONUP message is sent when the user releases the right mouse button while the cursor is on a menu item.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MENUDRAG">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MENUDRAG message is sent to the owner of a drag-and-drop menu when the user drags a menu item.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MENUGETOBJECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MENUGETOBJECT message is sent to the owner of a drag-and-drop menu when the mouse cursor enters a menu item or moves from the center of the item to the top or bottom of the item.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.UNINITMENUPOPUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_UNINITMENUPOPUP message is sent when a drop-down menu or submenu has been destroyed.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MENUCOMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MENUCOMMAND message is sent when the user makes a selection from a menu.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CHANGEUISTATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_CHANGEUISTATE message to indicate that the user interface (UI) state should be changed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.UPDATEUISTATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_UPDATEUISTATE message to change the user interface (UI) state for the specified window and all its child windows.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.QUERYUISTATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_QUERYUISTATE message to retrieve the user interface (UI) state for a window.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CTLCOLORMSGBOX">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CTLCOLORMSGBOX message is sent to the owner window of a message box before Windows draws the message box. By responding to this message, the owner window can set the text and background colors of the message box by using the given display device context handle.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CTLCOLOREDIT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An edit control that is not read-only or disabled sends the WM_CTLCOLOREDIT message to its parent window when the control is about to be drawn. By responding to this message, the parent window can use the specified device context handle to set the text and background colors of the edit control.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CTLCOLORLISTBOX">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to the parent window of a list box before the system draws the list box. By responding to this message, the parent window can set the text and background colors of the list box by using the specified display device context handle.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CTLCOLORBTN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CTLCOLORBTN message is sent to the parent window of a button before drawing the button. The parent window can change the button's text and background colors. However, only owner-drawn buttons respond to the parent window processing this message.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CTLCOLORDLG">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CTLCOLORDLG message is sent to a dialog box before the system draws the dialog box. By responding to this message, the dialog box can set its text and background colors using the specified display device context handle.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CTLCOLORSCROLLBAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CTLCOLORSCROLLBAR message is sent to the parent window of a scroll bar control when the control is about to be drawn. By responding to this message, the parent window can use the display context handle to set the background color of the scroll bar control.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CTLCOLORSTATIC">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            A static control, or an edit control that is read-only or disabled, sends the WM_CTLCOLORSTATIC message to its parent window when the control is about to be drawn. By responding to this message, the parent window can use the specified device context handle to set the text and background colors of the static control.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSEFIRST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Use WM_MOUSEFIRST to specify the first mouse message. Use the PeekMessage() Function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOUSEMOVE message is posted to a window when the cursor moves. If the mouse is not captured, the message is posted to the window that contains the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.LBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_LBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.LBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_LBUTTONUP message is posted when the user releases the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.LBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_LBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.RBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_RBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.RBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_RBUTTONUP message is posted when the user releases the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.RBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_RBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MBUTTONUP message is posted when the user releases the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSEWHEEL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOUSEWHEEL message is sent to the focus window when the mouse wheel is rotated. The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the parent chain until it finds a window that processes it.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.XBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_XBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.XBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_XBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.XBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_XBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSEHWHEEL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOUSEHWHEEL message is sent to the focus window when the mouse's horizontal scroll wheel is tilted or rotated. The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the parent chain until it finds a window that processes it.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSELAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Use WM_MOUSELAST to specify the last mouse message. Used with PeekMessage() Function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PARENTNOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_PARENTNOTIFY message is sent to the parent of a child window when the child window is created or destroyed, or when the user clicks a mouse button while the cursor is over the child window. When the child window is being created, the system sends WM_PARENTNOTIFY just before the CreateWindow or CreateWindowEx function that creates the window returns. When the child window is being destroyed, the system sends the message before any processing to destroy the window takes place.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ENTERMENULOOP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ENTERMENULOOP message informs an application's main window procedure that a menu modal loop has been entered.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.EXITMENULOOP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_EXITMENULOOP message informs an application's main window procedure that a menu modal loop has been exited.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NEXTMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NEXTMENU message is sent to an application when the right or left arrow key is used to switch between the menu bar and the system menu.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SIZING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SIZING message is sent to a window that the user is resizing. By processing this message, an application can monitor the size and position of the drag rectangle and, if needed, change its size or position.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CAPTURECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CAPTURECHANGED message is sent to the window that is losing the mouse capture.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOVING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOVING message is sent to a window that the user is moving. By processing this message, an application can monitor the position of the drag rectangle and, if needed, change its position.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.POWERBROADCAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Notifies applications that a power-management event has occurred.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DEVICECHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Notifies an application of a change to the hardware configuration of a device or the computer.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDICREATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDICREATE message to a multiple-document interface (MDI) client window to create an MDI child window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDIDESTROY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDIDESTROY message to a multiple-document interface (MDI) client window to close an MDI child window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDIACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDIACTIVATE message to a multiple-document interface (MDI) client window to instruct the client window to activate a different MDI child window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDIRESTORE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDIRESTORE message to a multiple-document interface (MDI) client window to restore an MDI child window from maximized or minimized size.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDINEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDINEXT message to a multiple-document interface (MDI) client window to activate the next or previous child window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDIMAXIMIZE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDIMAXIMIZE message to a multiple-document interface (MDI) client window to maximize an MDI child window. The system resizes the child window to make its client area fill the client window. The system places the child window's window menu icon in the rightmost position of the frame window's menu bar, and places the child window's restore icon in the leftmost position. The system also appends the title bar text of the child window to that of the frame window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDITILE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDITILE message to a multiple-document interface (MDI) client window to arrange all of its MDI child windows in a tile format.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDICASCADE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDICASCADE message to a multiple-document interface (MDI) client window to arrange all its child windows in a cascade format.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDIICONARRANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDIICONARRANGE message to a multiple-document interface (MDI) client window to arrange all minimized MDI child windows. It does not affect child windows that are not minimized.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDIGETACTIVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDIGETACTIVE message to a multiple-document interface (MDI) client window to retrieve the handle to the active MDI child window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDISETMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDISETMENU message to a multiple-document interface (MDI) client window to replace the entire menu of an MDI frame window, to replace the window menu of the frame window, or both.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ENTERSIZEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ENTERSIZEMOVE message is sent one time to a window after it enters the moving or sizing modal loop. The window enters the moving or sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns.[m[41m [m
[32m+[m[32m            The system sends the WM_ENTERSIZEMOVE message regardless of whether the dragging of full windows is enabled.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.EXITSIZEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_EXITSIZEMOVE message is sent one time to a window, after it has exited the moving or sizing modal loop. The window enters the moving or sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DROPFILES">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent when the user drops a file on the window of an application that has registered itself as a recipient of dropped files.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MDIREFRESHMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_MDIREFRESHMENU message to a multiple-document interface (MDI) client window to refresh the window menu of the MDI frame window.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_SETCONTEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application when a window is activated. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_NOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application to notify it of changes to the IME window. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_CONTROL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent by an application to direct the IME window to carry out the requested command. The application uses this message to control the IME window that it has created. To send this message, the application calls the SendMessage function with the following parameters.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_COMPOSITIONFULL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application when the IME window finds no space to extend the area for the composition window. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_SELECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application when the operating system is about to change the current IME. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_CHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application when the IME gets a character of the conversion result. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_REQUEST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application to provide commands and request information. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_KEYDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application by the IME to notify the application of a key press and to keep message order. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.IME_KEYUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to an application by the IME to notify the application of a key release and to keep message order. A window receives this message through its WindowProc function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSEHOVER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOUSEHOVER message is posted to a window when the cursor hovers over the client area of the window for the period of time specified in a prior call to TrackMouseEvent.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.MOUSELEAVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_MOUSELEAVE message is posted to a window when the cursor leaves the client area of the window specified in a prior call to TrackMouseEvent.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCMOUSEHOVER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCMOUSEHOVER message is posted to a window when the cursor hovers over the nonclient area of the window for the period of time specified in a prior call to TrackMouseEvent.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.NCMOUSELEAVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_NCMOUSELEAVE message is posted to a window when the cursor leaves the nonclient area of the window specified in a prior call to TrackMouseEvent.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.WTSSESSION_CHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_WTSSESSION_CHANGE message notifies applications of changes in session state.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CUT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_CUT message to an edit control or combo box to delete (cut) the current selection, if any, in the edit control and copy the deleted text to the clipboard in CF_TEXT format.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.COPY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_COPY message to an edit control or combo box to copy the current selection to the clipboard in CF_TEXT format.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PASTE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_PASTE message to an edit control or combo box to copy the current content of the clipboard to the edit control at the current caret position. Data is inserted only if the clipboard contains data in CF_TEXT format.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CLEAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_CLEAR message to an edit control or combo box to delete (clear) the current selection, if any, from the edit control.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.UNDO">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends a WM_UNDO message to an edit control to undo the last operation. When this message is sent to an edit control, the previously deleted text is restored or the previously added text is deleted.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.RENDERFORMAT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_RENDERFORMAT message is sent to the clipboard owner if it has delayed rendering a specific clipboard format and if an application has requested data in that format. The clipboard owner must render data in the specified format and place it on the clipboard by calling the SetClipboardData function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.RENDERALLFORMATS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_RENDERALLFORMATS message is sent to the clipboard owner before it is destroyed, if the clipboard owner has delayed rendering one or more clipboard formats. For the content of the clipboard to remain available to other applications, the clipboard owner must render data in all the formats it is capable of generating, and place the data on the clipboard by calling the SetClipboardData function.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DESTROYCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_DESTROYCLIPBOARD message is sent to the clipboard owner when a call to the EmptyClipboard function empties the clipboard.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DRAWCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_DRAWCLIPBOARD message is sent to the first window in the clipboard viewer chain when the content of the clipboard changes. This enables a clipboard viewer window to display the new content of the clipboard.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PAINTCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_PAINTCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format and the clipboard viewer's client area needs repainting.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.VSCROLLCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_VSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's vertical scroll bar. The owner should scroll the clipboard image and update the scroll bar values.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SIZECLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_SIZECLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format and the clipboard viewer's client area has changed size.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.ASKCBFORMATNAME">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_ASKCBFORMATNAME message is sent to the clipboard owner by a clipboard viewer window to request the name of a CF_OWNERDISPLAY clipboard format.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CHANGECBCHAIN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CHANGECBCHAIN message is sent to the first window in the clipboard viewer chain when a window is being removed from the chain.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSCROLLCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_HSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window. This occurs when the clipboard contains data in the CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's horizontal scroll bar. The owner should scroll the clipboard image and update the scroll bar values.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.QUERYNEWPALETTE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            This message informs a window that it is about to receive the keyboard focus, giving the window the opportunity to realize its logical palette when it receives the focus.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PALETTEISCHANGING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_PALETTEISCHANGING message informs applications that an application is going to realize its logical palette.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PALETTECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            This message is sent by the OS to all top-level and overlapped windows after the window with the keyboard focus realizes its logical palette.[m[41m [m
[32m+[m[32m            This message enables windows that do not have the keyboard focus to realize their logical palettes and update their client areas.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HOTKEY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_HOTKEY message is posted when the user presses a hot key registered by the RegisterHotKey function. The message is placed at the top of the message queue associated with the thread that registered the hot key.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PRINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_PRINT message is sent to a window to request that it draw itself in the specified device context, most commonly in a printer device context.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.PRINTCLIENT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_PRINTCLIENT message is sent to a window to request that it draw its client area in the specified device context, most commonly in a printer device context.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.APPCOMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_APPCOMMAND message notifies a window that the user generated an application command event, for example, by clicking an application command button using the mouse or typing an application command key on the keyboard.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.THEMECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_THEMECHANGED message is broadcast to every window following a theme change event. Examples of theme change events are the activation of a theme, the deactivation of a theme, or a transition from one theme to another.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CLIPBOARDUPDATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent when the contents of the clipboard have changed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DWMCOMPOSITIONCHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The system will send a window the WM_DWMCOMPOSITIONCHANGED message to indicate that the availability of desktop composition has changed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DWMNCRENDERINGCHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_DWMNCRENDERINGCHANGED is called when the non-client area rendering status of a window has changed. Only windows that have set the flag DWM_BLURBEHIND.fTransitionOnMaximized to true will get this message.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DWMCOLORIZATIONCOLORCHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to all top-level windows when the colorization color has changed.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.DWMWINDOWMAXIMIZEDCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_DWMWINDOWMAXIMIZEDCHANGE will let you know when a DWM composed window is maximized. You also have to register for this message as well. You'd have other windowd go opaque when this message is sent.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.GETTITLEBARINFOEX">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sent to request extended title bar information. A window receives this message through its WindowProc function.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.APP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_APP constant is used by applications to help define private messages, usually of the form WM_APP+X, where X is an integer value.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.USER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_USER constant is used by applications to help define private messages for use by private window classes, usually of the form WM_USER+X, where X is an integer value.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CPL_LAUNCH">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            An application sends the WM_CPL_LAUNCH message to Windows Control Panel to request that a Control Panel application be started.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.CPL_LAUNCHED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The WM_CPL_LAUNCHED message is sent when a Control Panel application, started by the WM_CPL_LAUNCH message, has closed. The WM_CPL_LAUNCHED message is sent to the window identified by the wParam parameter of the WM_CPL_LAUNCH message that started the application.[m[41m [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.SYSTIMER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_SYSTIMER is a well-known yet still undocumented message. Windows uses WM_SYSTIMER for internal actions like scrolling.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_ACCESSIBILITYSTATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The accessibility state has changed.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_ACTIVATESHELLWINDOW">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The shell should activate its main window.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_APPCOMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The user completed an input event (for example, pressed an application command button on the mouse or an application command key on the keyboard), and the application did not handle the WM_APPCOMMAND message generated by that input.[m
[32m+[m[32m            If the Shell procedure handles the WM_COMMAND message, it should not call CallNextHookEx. See the Return Value section for more information.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_GETMINRECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            A window is being minimized or maximized. The system needs the coordinates of the minimized rectangle for the window.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_LANGUAGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Keyboard language was changed or a new keyboard layout was loaded.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_REDRAW">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The title of a window in the task bar has been redrawn.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_TASKMAN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The user has selected the task list. A shell application that provides a task list should return TRUE to prevent Windows from starting its task list.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_WINDOWCREATED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            A top-level, unowned window has been created. The window exists when the system calls this hook.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_WINDOWDESTROYED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            A top-level, unowned window is about to be destroyed. The window still exists when the system calls this hook.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_WINDOWACTIVATED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The activation has changed to a different top-level, unowned window.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Crown.WM.HSHELL_WINDOWREPLACED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            A top-level window is being replaced. The window exists when the system calls this hook.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Metro.ProgressOrientation.Horizontal">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sets the progressbar on horizontal orientation.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Metro.ProgressOrientation.Vertical">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sets the progressbar on vertical orientation.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Metro.ScrollOrientate.Horizontal">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sets the scrollbar on horizontal orientation.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Metro.ScrollOrientate.Vertical">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sets the scrollbar on vertical orientation.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Metro.TabStyle.Style1">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sets the TabControlStyle Style1.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Enum.Metro.TabStyle.Style2">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Sets the TabControlStyle Style2.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Forms.NightForm.IsOverTitleBarIcon(System.Windows.Forms.MouseEventArgs)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Returns true if the mouse is over the title bar icon.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.ButtonID.OK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the OK[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.ButtonID.CANCEL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the CANCEL[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.ButtonID.YES">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the YES[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.ButtonID.NO">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the NO[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.ButtonID.ABORT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the ABORT[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.ButtonID.RETRY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the RETRY[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.ButtonID.IGNORE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the IGNORE[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.en">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the en[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.de">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the de[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.es">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the es[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.it">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the it[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.fr">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the fr[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.ro">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the ro[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.pl">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the pl[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialFlexibleForm.TwoLetterISOLanguageID.tr">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Defines the tr[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:ReaLTaiizor.Forms.MaterialForm.WM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Window Messages[m
[32m+[m[32m            <see href="https://docs.microsoft.com/en-us/windows/win32/winmsg/about-messages-and-message-queues"/>[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.NonClientCalcSize">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_NCCALCSIZE[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.NonClientActivate">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_NCACTIVATE[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.NonClientLeftButtonDown">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_NCLBUTTONDOWN[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.SystemCommand">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_SYSCOMMAND[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.MouseMove">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_MOUSEMOVE[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.LeftButtonDown">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_LBUTTONDOWN[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.LeftButtonUp">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_LBUTTONUP[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.LeftButtonDoubleClick">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_LBUTTONDBLCLK[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.RightButtonDown">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_RBUTTONDOWN[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WM.ActivateApp">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WM_ACTIVATEAPP[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:ReaLTaiizor.Forms.MaterialForm.HT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Hit Test Results[m
[32m+[m[32m            <see href="https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest"/>[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.None">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTNOWHERE - Nothing under cursor[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.Caption">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTCAPTION - Titlebar[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.Left">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTLEFT - Left border[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.Right">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTRIGHT - Right border[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.Top">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTTOP - Top border[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.TopLeft">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTTOPLEFT - Top left corner[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.TopRight">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTTOPRIGHT - Top right corner[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.Bottom">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTBOTTOM - Bottom border[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.BottomLeft">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTBOTTOMLEFT - Bottom left corner[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.HT.BottomRight">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            HTBOTTOMRIGHT - Bottom right corner[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:ReaLTaiizor.Forms.MaterialForm.WS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Window Styles[m
[32m+[m[32m            <see href="https://docs.microsoft.com/en-us/windows/win32/winmsg/window-styles"/>[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WS.MinimizeBox">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WS_MINIMIZEBOX - Allow minimizing from taskbar[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WS.SizeFrame">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WS_SIZEFRAME - Required for Aero Snapping[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.WS.SysMenu">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            WS_SYSMENU - Trigger the creation of the system menu[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:ReaLTaiizor.Forms.MaterialForm.TPM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Track Popup Menu Flags[m
[32m+[m[32m            <see href="https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-trackpopupmenu"/>[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.TPM.LeftAlign">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            TPM_LEFTALIGN[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Forms.MaterialForm.TPM.ReturnCommand">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            TPM_RETURNCMD[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Forms.MaterialForm.GetWindowLongPtr(System.IntPtr,System.Int32)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m                Provides a single method to call either the 32-bit or 64-bit method based on the size of an <see cref="T:System.IntPtr"/> for getting the[m
[32m+[m[32m                Window Style flags.<br/>[m
[32m+[m[32m                <see href="https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getwindowlongptra">GetWindowLongPtr</see>[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Forms.MaterialForm.SetWindowLongPtr(System.IntPtr,System.Int32,System.IntPtr)">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m                Provides a single method to call either the 32-bit or 64-bit method based on the size of an <see cref="T:System.IntPtr"/> for setting the[m
[32m+[m[32m                Window Style flags.<br/>[m
[32m+[m[32m                <see href="https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setwindowlongptra">SetWindowLongPtr</see>[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.TabControlHitTest.TCHT_NOWHERE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The position is not over a tab.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.TabControlHitTest.TCHT_ONITEMICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The position is over a tab's icon.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.TabControlHitTest.TCHT_ONITEMLABEL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The position is over a tab's text.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.TabControlHitTest.TCHT_ONITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            The position is over a tab but not over its icon or its text. For owner-drawn tab controls, this value is specified if the position is anywhere over a tab.[m
[32m+[m[32m            TCHT_ONITEM is a bitwise-OR operation on TCHT_ONITEMICON and TCHT_ONITEMLABEL.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:ReaLTaiizor.Native.User32.Msgs">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specifies values from Msgs enumeration.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NULL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NULL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CREATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CREATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DESTROY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DESTROY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MOVE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SIZE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SIZE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ACTIVATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETFOCUS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETFOCUS enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_KILLFOCUS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_KILLFOCUS enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ENABLE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ENABLE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETREDRAW">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETREDRAW enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETTEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETTEXT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETTEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETTEXT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETTEXTLENGTH">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETTEXTLENGTH enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PAINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PAINT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CLOSE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CLOSE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_QUERYENDSESSION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_QUERYENDSESSION enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_QUIT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_QUIT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_QUERYOPEN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_QUERYOPEN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ERASEBKGND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ERASEBKGND enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SYSCOLORCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SYSCOLORCHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ENDSESSION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ENDSESSION enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SHOWWINDOW">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SHOWWINDOW enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_WININICHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_WININICHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETTINGCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETTINGCHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DEVMODECHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DEVMODECHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ACTIVATEAPP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ACTIVATEAPP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_FONTCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_FONTCHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_TIMECHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_TIMECHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CANCELMODE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CANCELMODE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETCURSOR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETCURSOR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MOUSEACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MOUSEACTIVATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CHILDACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CHILDACTIVATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_QUEUESYNC">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_QUEUESYNC enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETMINMAXINFO">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETMINMAXINFO enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PAINTICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PAINTICON enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ICONERASEBKGND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ICONERASEBKGND enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NEXTDLGCTL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NEXTDLGCTL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SPOOLERSTATUS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SPOOLERSTATUS enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DRAWITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DRAWITEM enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MEASUREITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MEASUREITEM enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DELETEITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DELETEITEM enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_VKEYTOITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_VKEYTOITEM enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CHARTOITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CHARTOITEM enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETFONT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETFONT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETFONT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETFONT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETHOTKEY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETHOTKEY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETHOTKEY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETHOTKEY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_QUERYDRAGICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_QUERYDRAGICON enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_COMPAREITEM">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_COMPAREITEM enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETOBJECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETOBJECT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_COMPACTING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_COMPACTING enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_COMMNOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_COMMNOTIFY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_WINDOWPOSCHANGING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_WINDOWPOSCHANGING enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_WINDOWPOSCHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_WINDOWPOSCHANGED enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_POWER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_POWER enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_COPYDATA">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_COPYDATA enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CANCELJOURNAL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CANCELJOURNAL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NOTIFY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_INPUTLANGCHANGEREQUEST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_INPUTLANGCHANGEREQUEST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_INPUTLANGCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_INPUTLANGCHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_TCARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_TCARD enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_HELP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_HELP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_USERCHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_USERCHANGED enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NOTIFYFORMAT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NOTIFYFORMAT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CONTEXTMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CONTEXTMENU enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_STYLECHANGING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_STYLECHANGING enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_STYLECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_STYLECHANGED enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DISPLAYCHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DISPLAYCHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETICON enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SETICON">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SETICON enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCCREATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCCREATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCDESTROY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified VK_RMENU enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCCALCSIZE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCCALCSIZE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCHITTEST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCHITTEST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCPAINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCPAINT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCACTIVATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_GETDLGCODE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_GETDLGCODE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SYNCPAINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SYNCPAINT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCMOUSEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCMOUSEMOVE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCLBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCLBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCLBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCLBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCLBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCLBUTTONDBLCLK enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCRBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCRBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCRBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCRBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCRBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCRBUTTONDBLCLK enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCMBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCMBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCMBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCMBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCMBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCMBUTTONDBLCLK enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCXBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCXBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NCXBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NCXBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_KEYDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_KEYDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_KEYUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_KEYUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CHAR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DEADCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DEADCHAR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SYSKEYDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SYSKEYDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SYSKEYUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SYSKEYUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SYSCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SYSCHAR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SYSDEADCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SYSDEADCHAR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_KEYLAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_KEYLAST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_STARTCOMPOSITION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_STARTCOMPOSITION enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_ENDCOMPOSITION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_ENDCOMPOSITION enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_COMPOSITION">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_COMPOSITION enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_KEYLAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_KEYLAST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_INITDIALOG">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_INITDIALOG enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_COMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_COMMAND enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SYSCOMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SYSCOMMAND enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_TIMER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_TIMER enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_HSCROLL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_HSCROLL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_VSCROLL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_VSCROLL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_INITMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_INITMENU enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_INITMENUPOPUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_INITMENUPOPUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MENUSELECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MENUSELECT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MENUCHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MENUCHAR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ENTERIDLE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ENTERIDLE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MENURBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MENURBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MENUDRAG">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MENUDRAG enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MENUGETOBJECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MENUGETOBJECT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_UNINITMENUPOPUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_UNINITMENUPOPUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MENUCOMMAND">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MENUCOMMAND enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CTLCOLORMSGBOX">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CTLCOLORMSGBOX enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CTLCOLOREDIT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CTLCOLOREDIT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CTLCOLORLISTBOX">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CTLCOLORLISTBOX enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CTLCOLORBTN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CTLCOLORBTN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CTLCOLORDLG">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CTLCOLORDLG enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CTLCOLORSCROLLBAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CTLCOLORSCROLLBAR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CTLCOLORSTATIC">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CTLCOLORSTATIC enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MOUSEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MOUSEMOVE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_LBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_LBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_LBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_LBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_LBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_LBUTTONDBLCLK enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_RBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_RBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_RBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_RBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_RBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_RBUTTONDBLCLK enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MBUTTONDBLCLK enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MOUSEWHEEL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MOUSEWHEEL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_XBUTTONDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_XBUTTONDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_XBUTTONUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_XBUTTONUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_XBUTTONDBLCLK">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_XBUTTONDBLCLK enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PARENTNOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PARENTNOTIFY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ENTERMENULOOP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ENTERMENULOOP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_EXITMENULOOP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_EXITMENULOOP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_NEXTMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_NEXTMENU enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SIZING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SIZING enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CAPTURECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CAPTURECHANGED enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MOVING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MOVING enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DEVICECHANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DEVICECHANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDICREATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDICREATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDIDESTROY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDIDESTROY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDIACTIVATE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDIACTIVATE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDIRESTORE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDIRESTORE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDINEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDINEXT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDIMAXIMIZE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDIMAXIMIZE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDITILE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDITILE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDICASCADE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDICASCADE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDIICONARRANGE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDIICONARRANGE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDIGETACTIVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDIGETACTIVE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDISETMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDISETMENU enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ENTERSIZEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ENTERSIZEMOVE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_EXITSIZEMOVE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_EXITSIZEMOVE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DROPFILES">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DROPFILES enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MDIREFRESHMENU">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MDIREFRESHMENU enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_SETCONTEXT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_SETCONTEXT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_NOTIFY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_NOTIFY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_CONTROL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_CONTROL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_COMPOSITIONFULL">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_COMPOSITIONFULL enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_SELECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_SELECT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_CHAR">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_CHAR enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_REQUEST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_REQUEST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_KEYDOWN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_KEYDOWN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_IME_KEYUP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_IME_KEYUP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_MOUSEHOVER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_MOUSEHOVER enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_UNDO">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_UNDO enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_RENDERFORMAT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_RENDERFORMAT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_RENDERALLFORMATS">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_RENDERALLFORMATS enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DESTROYCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DESTROYCLIPBOARD enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_DRAWCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_DRAWCLIPBOARD enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PAINTCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PAINTCLIPBOARD enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_VSCROLLCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_VSCROLLCLIPBOARD enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_SIZECLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_SIZECLIPBOARD enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_ASKCBFORMATNAME">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_ASKCBFORMATNAME enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_CHANGECBCHAIN">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_CHANGECBCHAIN enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_HSCROLLCLIPBOARD">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_HSCROLLCLIPBOARD enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_QUERYNEWPALETTE">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_QUERYNEWPALETTE enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PALETTEISCHANGING">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PALETTEISCHANGING enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PALETTECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PALETTECHANGED enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_HOTKEY">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_HOTKEY enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PRINT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PRINT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PRINTCLIENT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PRINTCLIENT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_HANDHELDFIRST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_HANDHELDFIRST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_HANDHELDLAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_HANDHELDLAST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_AFXFIRST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_AFXFIRST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_AFXLAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_AFXLAST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PENWINFIRST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PENWINFIRST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_PENWINLAST">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_PENWINLAST enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_APP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_APP enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_USER">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_USER enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_REFLECT">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_REFLECT enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Native.User32.Msgs.WM_THEMECHANGED">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Specified WM_THEMECHANGED enumeration value.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:ReaLTaiizor.Properties.Resources">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              Yerelleştirilmiş dizeleri aramak gibi işlemler için, türü kesin olarak belirtilmiş kaynak sınıfı.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.ResourceManager">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              Bu sınıf tarafından kullanılan, önbelleğe alınmış ResourceManager örneğini döndürür.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Culture">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              Tümü için geçerli iş parçacığının CurrentUICulture özelliğini geçersiz kular[m
[32m+[m[32m              CurrentUICulture özelliğini tüm kaynak aramaları için geçersiz kılar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Check">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Close">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Error">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Google">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Information">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Maximize">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Minimize">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Question">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Taiizor">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Taiizor1">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              (Simge) öğesine benzeyen System.Drawing.Icon türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Twitter">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Warning">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.lnkClearImage">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.lnkClearNoFocusImage">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.tick">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.grip">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.close_normal">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.close_selected">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.active_inactive_close">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.inactive_close_selected">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.inactive_close">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.arrow">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.tw_close">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.tw_close_selected">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.tw_active_close">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.tw_active_close_selected">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.scrollbar_arrow_hot">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.scrollbar_arrow_clicked">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.scrollbar_arrow_disabled">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.scrollbar_arrow_standard">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.node_closed_empty">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.node_closed_full">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.node_open">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.node_open_empty">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.info">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.warn">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.err">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.scrollbar_arrow_small_clicked">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.scrollbar_arrow_small_hot">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.scrollbar_arrow_small_standard">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.small_arrow">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.color_picker">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.mini_button">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Metro_Theme">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.String türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Roboto_Black">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Roboto_Bold">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Roboto_Light">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Roboto_Medium">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Roboto_Regular">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Roboto_Thin">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.SegoeWP_Semilight">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.SegoeWP_Light">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.SegoeWP_Semibold">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.SegoeWP_Bold">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.SegoeWP">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Open_Sans">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Open_Sans_Bold">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="P:ReaLTaiizor.Properties.Resources.Open_Sans_Light">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m              System.Byte[] türünde yerelleştirilmiş bir kaynak arar.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.DrawEngine.RoundedRectangle(System.Drawing.Rectangle,System.Single)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="rectangle"></param>[m
[32m+[m[32m            <param name="value_angle"></param>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.DrawEngine.DrawBlurred(System.Drawing.Graphics,System.Drawing.Color,System.Drawing.Point,System.Drawing.Point,System.Int32,System.Int32)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="graphics"></param>[m
[32m+[m[32m            <param name="color"></param>[m
[32m+[m[32m            <param name="point_1"></param>[m
[32m+[m[32m            <param name="point_2"></param>[m
[32m+[m[32m            <param name="max_alpha"></param>[m
[32m+[m[32m            <param name="pen_width"></param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.DrawEngine.DrawBlurred(System.Drawing.Graphics,System.Drawing.Color,System.Drawing.Drawing2D.GraphicsPath,System.Int32,System.Int32)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="graphics"></param>[m
[32m+[m[32m            <param name="color"></param>[m
[32m+[m[32m            <param name="graphicsPath"></param>[m
[32m+[m[32m            <param name="max_alpha"></param>[m
[32m+[m[32m            <param name="pen_width"></param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Util.CyberLibrary.DrawEngine.Temp">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Util.CyberLibrary.DrawEngine.GlobalRGB">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.DrawEngine.TimerGlobalRGB(System.Boolean)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="status"></param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.DrawEngine.HSV_To_RGB(System.Single,System.Single,System.Single)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="hue"></param>[m
[32m+[m[32m            <param name="saturation"></param>[m
[32m+[m[32m            <param name="value"></param>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.HelpEngine.Error(System.String)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="text"></param>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetDefaultFont(System.String,System.Single,System.Drawing.FontStyle)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="familyName"></param>[m
[32m+[m[32m            <param name="emSize"></param>[m
[32m+[m[32m            <param name="fontStyle"></param>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetGraphics(System.Drawing.Bitmap@,System.Drawing.Drawing2D.SmoothingMode,System.Drawing.Text.TextRenderingHint)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="bitmap"></param>[m
[32m+[m[32m            <param name="SmoothingMode"></param>[m
[32m+[m[32m            <param name="TextRenderingHint"></param>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetRandom">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="F:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetRandom.Randomise">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetRandom.ColorArgb(System.Int32)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="alpha"></param>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetRandom.Int(System.Int32,System.Int32)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="min"></param>[m
[32m+[m[32m            <param name="max"></param>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetRandom.Float(System.Int32,System.Int32)">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <param name="min"></param>[m
[32m+[m[32m            <param name="max"></param>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:ReaLTaiizor.Util.CyberLibrary.HelpEngine.GetRandom.Bool">[m
[32m+[m[32m            <summary>[m
[32m+[m[41m            [m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <returns></returns>[m
[32m+[m[32m        </member>[m
[32m+[m[32m    </members>[m
[32m+[m[32m</doc>[m
