namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random ratstgele = new Random();
        int toplambirinci = 0;
        int toplamikinci = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = ratstgele.Next(1,7);
            int b = ratstgele.Next(1, 7);

            toplambirinci = toplambirinci + a + b;
            label6.Text = toplambirinci.ToString();
            
            if(a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\51.jpg";
            }

            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\52.jpg";
            }

            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\53.jpg";
            }

            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\54.jpg";
            }

            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\55.jpg";
            }

            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\56.jpg";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\51.jpg";
            }

            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\52.jpg";
            }

            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\53.jpg";
            }

            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\54.jpg";
            }

            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\55.jpg";
            }

            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\56.jpg";
            }


            label3.Text = a.ToString();
            label4.Text = b.ToString();  
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = ratstgele.Next(1, 7);
            int b = ratstgele.Next(1, 7);

            toplamikinci = toplamikinci + a + b;
            label7.Text = toplamikinci.ToString();

            if (a == 1)
            {
                pictureBox4.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\51.jpg";
            }

            if (a == 2)
            {
                pictureBox4.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\52.jpg";
            }

            if (a == 3)
            {
                pictureBox4.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\53.jpg";
            }

            if (a == 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\54.jpg";
            }

            if (a == 5)
            {
                pictureBox4.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\55.jpg";
            }

            if (a == 6)
            {
                pictureBox4.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\56.jpg";
            }

            if (b == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\51.jpg";
            }

            if (b == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\52.jpg";
            }

            if (b == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\53.jpg";
            }

            if (b == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\54.jpg";
            }

            if (b == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\55.jpg";
            }

            if (b == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\SEDA\\OneDrive\\Masaüstü\\PROJELER\\C# resimleri\\56.jpg";
            }

            if(toplambirinci > 60 )
            {
                label18.Text = "Birinci Oyuncu Kazandý ve Puaný:"   + toplambirinci.ToString();
            }

            if (toplamikinci > 60 )
            {
                label18.Text = "Ýkinci Oyuncu Kazandý ve Puaný: " + toplamikinci.ToString();
            }

            label10.Text = a.ToString();
            label9.Text = b.ToString();


        }

        }
    
}