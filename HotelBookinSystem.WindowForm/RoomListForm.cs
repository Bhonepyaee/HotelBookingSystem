﻿namespace HotelBookinSystem.WindowForm;

public partial class RoomListForm : Form
{
    public RoomListForm()
    {
        InitializeComponent();
    }

    private async void RoomListForm_Load(object sender, EventArgs e)
    {
        try
        {
            string query = RoomQuery.GetRoomQuery;
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
        RoomForm roomForm = new RoomForm();
        roomForm.Show();
        this.Hide();
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
        MenuForm menuForm = new MenuForm();
        menuForm.Show();
        this.Hide();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
