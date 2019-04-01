using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace NCR.StudenDB
{
    public class StudentDB
    {

        public DataTable getStreams()
        {

            SqlConnection con = new SqlConnection("Server=DESKTOP-SS5H7HT;DataBase=ncr;Uid=ncr;Password=pass1234;");
            string command = "SP_GetStream";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }
        public DataTable getTransportModes()
        {

            SqlConnection con = new SqlConnection("Server=DESKTOP-SS5H7HT;DataBase=ncr;Uid=ncr;Password=pass1234;");
            string command = "SP_GetTranportModes";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }

        public bool SaveStudent(NCR.Entities.StudentEnt ent)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-SS5H7HT;DataBase=ncr;Uid=ncr;Password=pass1234;");
            string command = "SP_SaveStudent";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.Parameters.Add(new SqlParameter("@name", ent.Name));
            cmd.Parameters.Add(new SqlParameter("@stream", ent.Course));
            cmd.Parameters.Add(new SqlParameter("@transport", ent.Transport));
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
