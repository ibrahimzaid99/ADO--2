using Iti.Bll;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;

namespace Iti.Pl
{
    public partial class TopicForm : Form
    {
        TopicBL topicBL;
        DataTable dataTable;
        SqlDataAdapter adapter;
        SqlConnection conn;


        public TopicForm()
        {
            InitializeComponent();
            topicBL = new TopicBL();
            conn = new SqlConnection();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable = topicBL.GetAllV1();
            dgv_topic.DataSource = dataTable;

            //DataTable dataTable = new DataTable();

            //dgv_topic.DataSource = dataTable;

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int affectedRows = topicBL.Insert(txt_name.Text);

            if (affectedRows > 0)
            {
                MessageBox.Show("Data have been added");
            }
        }
        int id;
        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            int rowsAffected = topicBL.Update(id, name);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Record updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update record.");
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int crruntid = id;
            int efectedrow = topicBL.delete(id);
            if (efectedrow > 0)
            {
                MessageBox.Show("Record delete successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete record.");
            }

        }
        private void dgv_topic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataTable.Rows[e.RowIndex]["Top_Id"];
            MessageBox.Show("cated id :)");
        }
    }
}