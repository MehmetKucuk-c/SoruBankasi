using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SoruBankasi
{
    public class DataBase
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FGPFH37;Initial Catalog=SoruBankası;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
