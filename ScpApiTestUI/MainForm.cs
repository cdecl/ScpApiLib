using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScpApiTestUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            try
            {
                ScpApiLib.ScpApi lib = new ScpApiLib.ScpApi();

                txtEnc.Text = lib.Encrypt(txtPath.Text, txtKey.Text, txtText.Text);
                txtDec.Text = lib.Decrypt(txtEnc.Text, txtKey.Text, txtText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

  
    }
}
