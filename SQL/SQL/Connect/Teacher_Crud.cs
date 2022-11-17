using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL.Connect
{
    public class Teacher_Crud
    {
        string query = "";
        SqlConnection con = new SqlConnection(Dalc.GetConnect);
        SqlCommand cmd;
        int result;
        bool ren;
        public int Insert(string teacher_name,string teacher_surname,string teacher_gender,string teacher_subject,string teacher_email)
        {

            query = "insert into Teacher values('" + teacher_name + "','" + teacher_surname + "','" + teacher_gender + "','" + teacher_subject + "','" + teacher_email + "')";
            cmd = new SqlCommand(query,con);
            try
            {
                if(con.State!=ConnectionState.Open)
                {
                    con.Open();
                }
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    result = 2;
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }
        public int Update(int id, string teacher_name, string teacher_surname, string teacher_gender, string teacher_subject, string teacher_email)
        {
            con.Open();
            if(id<0)
            {
                return 0;
            }
            
            string quer = "select *  from Teacher where id=" + id;
            SqlCommand cmd = new SqlCommand(quer, con);
            SqlDataReader ds=cmd.ExecuteReader();
            while (ds.Read())
            {
                if(teacher_name=="")
                {
                    teacher_name = ds[1].ToString();
                }
                if (teacher_surname == "")
                {
                    teacher_surname = ds[2].ToString();
                }
                if (teacher_subject == "")
                {
                    teacher_subject = ds[3].ToString();
                }
                if (teacher_gender == "")
                {
                    teacher_gender = ds[4].ToString();
                }
                if (teacher_email == "")
                { 
                    teacher_email = ds[5].ToString();
                }
            }
            ds.Close();
            con.Close();
            query = "Update Teacher set teacher_name='"+teacher_name+"',teacher_surname='"+teacher_surname+"',teacher_gender='"+teacher_gender+"',teacher_subject='"+teacher_subject+"',teacher_mail='"+teacher_email+"'where id="+id;

            cmd = new SqlCommand(query,con);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    result = 2;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }
        public int Delete(int id)
        {
            query = "Delete from Teacher where id=" + id;
            cmd=new SqlCommand(query,con);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    result = 2;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }
        public List<Teacher> Select()
        {
            string query = "select * from Teacher";
            cmd=new SqlCommand(query,con);
            List<Teacher> list = new List<Teacher>();
            try
            {
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr=cmd.ExecuteReader();
                while(dr.Read())
                {
                    list.Add(new Teacher((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString()));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(con.State!= ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return list;
        }
        public bool id_select(int ID)
        {
            string query = "select id from Teacher where id="+ID;
            cmd=new SqlCommand(query,con);
            try
            {
                string t="";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                IDataReader dr=cmd.ExecuteReader();
                if (dr.Read())
                {
                     t = dr[0].ToString();
                }
                if (t==ID.ToString())
                {
                    ren = true;
                }
                else
                {
                    ren = false;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            
            return ren;
        }
    }
}
