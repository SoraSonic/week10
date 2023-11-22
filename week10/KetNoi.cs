using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace week10
{
    public class KetNoi
    {
        public SqlConnection connect;
        public KetNoi()
        {
            connect = new SqlConnection("Data source= A209PC29; Initial Catalog = QUESTION ; Integrated Security = True");
        }
        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
