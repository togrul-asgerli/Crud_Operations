using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using SQL.Connect;
using System.Text.RegularExpressions;

namespace SQL
{
    public partial class Form1 : Form
    {
        Teacher_Crud ds=new Teacher_Crud();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Grid_tab.DataSource = ds.Select();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(txt_name.Text==""||txt_surname.Text==""||txt_gender.Text=="")
            {
                MessageBox.Show("This name ,surname or gender cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int a=ds.Insert(txt_name.Text, txt_surname.Text, txt_gender.Text, txt_subject.Text, txt_mail.Text);
            if(a==2)
            {
                MessageBox.Show("Insert Succesfull!");
            }
            else
            {
                MessageBox.Show("Insert Unsuccesfull!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string regex = @"^[0-9]";
            Regex rg = new Regex(regex);

            if (!rg.IsMatch(txt_id.Text))
            {
                MessageBox.Show("Id can't be non numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_id.Text == "")
            {
                MessageBox.Show("Id cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(txt_id.Text) <= 0)
            {
                MessageBox.Show("Id cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int a = ds.Update(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_surname.Text, txt_gender.Text, txt_subject.Text, txt_mail.Text);
            if(a==2)
            {
                MessageBox.Show("Update Succesfull!");
             }
            else
                {
                    MessageBox.Show("Update Unsuccesfull!");
                }
            }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string regex = @"^[0-9]";
            Regex rg = new Regex(regex);

            if (!rg.IsMatch(txt_id.Text))
            {
                MessageBox.Show("Id can't be non numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_id.Text=="")
            {
                MessageBox.Show("Id cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(txt_id.Text) <= 0)
            {
                MessageBox.Show("Id cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!ds.id_select(Convert.ToInt32(txt_id.Text)))
            {
                MessageBox.Show("Enter valid Id","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int a=ds.Delete(Convert.ToInt32(txt_id.Text));

            if(a==2)
            {
                MessageBox.Show("Delete Succesfull!");
            }
            else
            {
                MessageBox.Show("Delete Unsuccesfull!");
            }
        }
    }
}
