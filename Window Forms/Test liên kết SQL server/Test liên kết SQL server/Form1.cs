using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Test_liên_kết_SQL_server
{


    public partial class Form1 : Form
    {
        //tạo 2 biến cục bộ
        string strcon = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";
        //dấu @ dùng để thể hiện đây là 1 chuỗi chứ không phải là phép tính hay gì đó khác.
        //Đối tượng kết nối
        SqlConnection sqlcon = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlcon == null) 
                {
                    sqlcon = new SqlConnection(strcon); //rỗng thì tạo mới.
                }
                //mở kết nối 
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();  //Đóng thì mở
                    MessageBox.Show("Kết nối thành công");
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show(ax.Message);
            }
        }

        private void btnDongKetNoi_Click(object sender, EventArgs e)
        {
            if (sqlcon != null && sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close(); //Mở thì đóng
                MessageBox.Show("Đóng kết nối thành công");
            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối!");
            }
        }
    }
}