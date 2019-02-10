using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace MIS_PROJECT
{
    public class Data
    {
        public static SqlConnection Connection { get; set; }

        public static Boolean TestConnection(MetroForm frm)
        {
            try
            {
                Connection = new SqlConnection("SERVER=localhost;DATABASE=CAR_WASHING;Trusted_Connection=true");
                Connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(frm, "Connect Failed" + Environment.NewLine + ex.Message, "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static void ExecuteNonQuery(String sql)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, Connection);
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Dispose();
        }

        public static object ExecuteScale(String sql)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, Connection);
            object obj = sqlcmd.ExecuteScalar();
            sqlcmd.Dispose();
            return obj;
        }

        public static object ExecuteScale(String sql, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, Connection);
            sqlcmd.Parameters.AddRange(param);
            object obj = sqlcmd.ExecuteScalar();
            sqlcmd.Dispose();
            return obj;
        }

        public static object ExecuteNonQuery(String sql, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(sql, Connection);
            sqlcmd.Parameters.AddRange(param);
            object obj = sqlcmd.ExecuteScalar();
            sqlcmd.Dispose();
            return obj;
        }

        public static DataTable Datatable(String sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }

        public static SqlParameter[] GetParam(string[] values)
        {
            SqlParameter[] tempparam = new SqlParameter[values.Length];
            for (int i = 1; i <= values.Length; i++)
            {
                tempparam[i - 1] = new SqlParameter("@sub" + i, values[i - 1]);
            }
            return tempparam;
        }
    }
}