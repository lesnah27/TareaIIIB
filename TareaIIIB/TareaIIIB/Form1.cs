using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TareaIIIB
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=empleado;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           

           
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from empleados", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
        
            Form2 frm = new Form2();
            frm.Show();
        }
      
            }
        }
   

