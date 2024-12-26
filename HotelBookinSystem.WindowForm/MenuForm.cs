namespace HotelBookinSystem.WindowForm;

public partial class MenuForm : Form
{
    public MenuForm()
    {
        InitializeComponent();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void MenuForm2_Load(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        CustomerListForm customerListForm = new CustomerListForm();
        customerListForm.Show();
        this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        BookingListForm bookingListForm = new BookingListForm();
        bookingListForm.Show();
        this.Hide();
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
        RoomListForm roomListForm = new RoomListForm();
        roomListForm.Show();
        this.Hide();
    }

    private void panel1_Paint_1(object sender, PaintEventArgs e)
    {

    }
}
