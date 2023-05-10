using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class AssignProjects : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        string strCon = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLDA;Integrated Security=True";
        SqlDataAdapter sqlDA = new SqlDataAdapter();
        DataTable dTable = new DataTable();
        SqlDataReader sqlDR = null;

        public AssignProjects()
        {
            InitializeComponent();
        }

        private void AssignProjects_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            LoadData();
        }

        public void LoadData()
        {
            sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandText = "SELECT MADA AS ID, TENDA AS 'Project Name', NGAYKETTHUC AS Deadline FROM DUAN";
            sqlDA.SelectCommand = sqlCmd;
            dTable.Clear();
            sqlDA.Fill(dTable);
            dgvProjects.DataSource = dTable;
        }
    }
}
