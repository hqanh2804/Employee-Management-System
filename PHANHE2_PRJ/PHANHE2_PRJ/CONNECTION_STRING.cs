using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE2_PRJ
{
    internal class CONNECTION_STRING
    {
        string PATH = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = XE)))";
        static string conStr = "";

        public string getString()
        {
            return conStr;
        }

        public void setConStr(string username, string password)
        {
            conStr = "Data Source = " + PATH + "; User Id = " + username + ";password=" + password;
        }

    }
}
