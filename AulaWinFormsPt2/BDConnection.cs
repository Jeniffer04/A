using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWinFormsPt2
{
    public static class BDConnection
    {
        //public static SqlConnection connection = new SqlConnection("Data Source=BUE205D16;Initial Catalog=BDTurmaVesp;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        public static SqlConnection connection { get; set; } = new SqlConnection("Data Source=BUE205D16;Initial Catalog=BDTurmaVesp;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        
    }
}
