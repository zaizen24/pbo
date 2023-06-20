namespace Promo_Pemesanan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void promo_Load(object sender, EventArgs e)
        {

        }
        private bool guna2Button1MouseClick = false;
        private bool guna2Button2MouseClick = false;
        private bool guna2Button3MouseClick = false;
        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else
            {
                guna2Button1.Text = "Digunakan";
                guna2Button1.ForeColor = Color.WhiteSmoke;
                guna2Button1.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button1MouseClick = true;
            }
            if (guna2Button2MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2Button2MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else
            {
                guna2Button2.Text = "Digunakan";
                guna2Button2.ForeColor = Color.WhiteSmoke;
                guna2Button2.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button2MouseClick = true;
            }
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3MouseClick)
            {
                guna2Button3.Text = "Gunakan";
                guna2Button3.ForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
            else
            {
                guna2Button3.Text = "Digunakan";
                guna2Button3.ForeColor = Color.WhiteSmoke;
                guna2Button3.FillColor = Color.FromArgb(102, 98, 98);
                MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button3MouseClick = true;
            }
            if (guna2Button1MouseClick)
            {
                guna2Button1.Text = "Gunakan";
                guna2Button1.ForeColor = Color.White;
                guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                guna2Button2.Text = "Gunakan";
                guna2Button2.ForeColor = Color.White;
                guna2Button2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
        }
    }
}