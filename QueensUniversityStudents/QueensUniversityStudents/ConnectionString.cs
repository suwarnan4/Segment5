using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueensUniversityStudents
{
    class ConnectionString
    {
        string myConnString = "Server=" + System.Environment.MachineName + @"\SQLExpress; Database=QueensUniversity; User Id=sa; Password=vfr4mju7;";

        public string MyConnString()
        {
            return myConnString;
        }
    }
}
