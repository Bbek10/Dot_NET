namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //grd_data.Rows.Clear();
            grd_data.Rows.Add(txt_id.Text, txt_name.Text, cmb_dep.Text, cmb_desg.Text, date_dob.Value.Date.ToString());


        }
    }
}
