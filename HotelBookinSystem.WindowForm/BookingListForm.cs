using System.Data;
using System.Data.SqlClient;
using HotelBookinSystem.WindowForm.Config;
using HotelBookinSystem.WindowForm.Query;

namespace HotelBookinSystem.WindowForm
{
    public partial class BookingListForm : Form
    {
        public BookingListForm()
        {
            InitializeComponent();
        }

        private async void BookingListForm_Load(object sender, EventArgs e)
        {
            try
            {
                string query = BookingQuery.GetBookingQuery;

                SqlConnection connection = new SqlConnection(DbConfig._connectionString);
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                await connection.CloseAsync();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
