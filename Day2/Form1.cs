using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Day2
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public Form1()
        {

            InitializeComponent();
            conn = new SqlConnection("server=.;database=ITi;trusted_connection=true;TrustServerCertificate=True;");
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetTopic();

        }
        void GetTopic()
        {
            SqlCommand cmd = new SqlCommand("select * from Topic ", conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);
            dgv_topic.DataSource = dataTable;
            dgv_topic.Columns[0].ReadOnly = true;
        }

        int CurentId;



        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();

            dataRow["Top_Name"] = txt_name.Text;

            dataTable.Rows.Add(dataRow);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataRow d in dataTable.Rows)
            {
                if ((int)d["Top_id"] == CurentId)
                {
                    d.Delete();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            foreach (DataRow d in dataTable.Rows)
            {
                if ((int)d["Top_id"] == CurentId)
                {
                    d["Top_name"] = txt_name.Text;

                }
            }


        }
        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming 'adapter', 'conn', and 'dataTable' are properly initialized.
                adapter.Update(dataTable);
                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        //private void btn_save_Click(object sender, EventArgs e)
        //{
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        Debug.WriteLine($"row {row.ToString()} => state => {row.RowState}");
        //    }
        //    Debug.WriteLine("==========================");

        //    adapter.UpdateCommand = new SqlCommand($"update Topic set top_name = @name  where Top_id=@Id ", conn);
        //    adapter.UpdateCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "top_name");
        //    adapter.UpdateCommand.Parameters.Add("Id", SqlDbType.Int, 4, "Top_id");

        //    adapter.InsertCommand = new SqlCommand("insert into Topic values(@name)", conn);
        //    adapter.InsertCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "top_name");
        //    adapter.InsertCommand.Parameters.Add("Id", SqlDbType.Int, 4, "Top_id");

        //    adapter.DeleteCommand = new SqlCommand();

        //    adapter.DeleteCommand = new SqlCommand("delete from Topic where top_id=@id", conn);
        //    adapter.DeleteCommand.Parameters.Add("id", SqlDbType.Int, 4, "top_Id");
        //    adapter.Update(dataTable);
        //    GetTopic();
        //}

        private void dgv_topic_MouseDoubleClick(object sender, MouseEventArgs e)
        {


        }
    }
}