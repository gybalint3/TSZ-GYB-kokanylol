using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TSZ_GYB_kokanylol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imgs", "lolhattér próba.webp"); if (File.Exists(imagePath)) { this.BackgroundImage = Image.FromFile(imagePath); }
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
