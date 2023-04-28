using QuanLyQuanCafe.DAO;
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

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            
        }

        void loadFoodlist()
        {
            string query = "SELECT * FROM FOOD";

            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadAccountList()
        {

            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            dtgvAccout.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"Trung"});

        }
    }
}
