using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PBKDF2_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genbtn_Click(object sender, EventArgs e)
        {
            string use = svctb.Text;
            while (use.Length < 8)
            {
                use += "O";
            }
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(passtb.Text, Encoding.UTF8.GetBytes(use.ToLower()), 4096);
            resulttb.Text = Convert.ToBase64String(rfc.GetBytes(6)).Replace("=", "");
        }
    }
}
