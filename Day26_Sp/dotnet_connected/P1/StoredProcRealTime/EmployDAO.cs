using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace StoredProcRealTime
{
    public class EmployDAO
    {
        SqlConnection connection;
        SqlCommand command;

        public List<Employ> ShowEmploy()
        {
            connection = ConnectionHelper.GetConnection();
            connection.Open();
            List<Employ> employList = new List<Employ>();
            Employ employ = null;
            command = new SqlCommand("prcEmployShow", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                employ = new Employ();
                employ.Empno = Convert.ToInt32(dr["empno"]);
                employ.Name = dr["name"].ToString();
                employ.Gender = dr["gender"].ToString();
                employ.Dept = dr["dept"].ToString();
                employ.Desig = dr["desig"].ToString();
                employ.Basic= Convert.ToInt32(dr["basic"]);
                employList.Add(employ);
            }
            connection.Close();
            command.Dispose();
            return employList;
        }

        public int AddEmploy(Employ employ)
        {
            connection = ConnectionHelper.GetConnection();
            connection.Open();
            command = new SqlCommand("prcEmployInsert", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@empno", SqlDbType.Int));
            command.Parameters["@empno"].Direction = ParameterDirection.Output;
            command.Parameters.AddWithValue("@name", employ.Name);
            command.Parameters.AddWithValue("@gender", employ.Gender);
            command.Parameters.AddWithValue("@dept", employ.Dept);
            command.Parameters.AddWithValue("@desig", employ.Desig);
            command.Parameters.AddWithValue("@basic", employ.Basic);
            command.ExecuteNonQuery();
            int empno = Convert.ToInt32(command.Parameters["@empno"].Value);
            return empno;
        }
        public Employ SearchEmploy(int empno)
        {
            connection = ConnectionHelper.GetConnection();
            connection.Open();
            List<Employ> employList = new List<Employ>();
            Employ employ = null;
            command = new SqlCommand("prcEmploySearch", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@empno", empno);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                employ = new Employ();
                employ.Empno = Convert.ToInt32(dr["empno"]);
                employ.Name = dr["name"].ToString();
                employ.Gender = dr["gender"].ToString();
                employ.Dept = dr["dept"].ToString();
                employ.Desig = dr["desig"].ToString();
                employ.Basic = Convert.ToInt32(dr["basic"]);
                employList.Add(employ);
            }
            connection.Close();
            command.Dispose();
            return employ;
        }
    }
}
