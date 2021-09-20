using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form03
{
    public static class Function
    {
        /// <summary>
        /// Faz a Conecção para ser usada durante o programa para fazer os forms
        /// </summary>
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=BUE205D16;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        /// <summary>
        /// This function returns all elements selected in the table, the already include dbo.table
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List<string> allSelectElements</string></returns>

        public static List<string> GenericUnitSelect(string element, string table)
        {

            List<string> returnElements = new List<string>();

            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand comand = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = comand.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();

            return returnElements;


        }




    }
}
