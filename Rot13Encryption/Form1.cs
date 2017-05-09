using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rot13Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            ArrayList input = new ArrayList();
            //fill array
            for (int i = 0; i > txtInput.TextLength; i++)
            {
                input.Add(txtInput.Text[i]);
            }
        }
    }
}
