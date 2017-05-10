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

        public ArrayList getInput()
        {
            ArrayList input = new ArrayList();
            // fill array
            for (int i = 0; i < txtInput.TextLength; i++)
            {
                input.Add(txtInput.Text[i].ToString().ToLower());
            }
            return input;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            ArrayList input = getInput();

            for (int i = 0; i < input.Count; i++)
            {
                // convert current letter to char
                char c = Convert.ToChar(input[i]);
                // increment char by 13
                input[i] = c = (char)('a' + (c - 'a' + 13) % 26);
            }
            showResult(input);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            getInput();
        }

        private void showResult(ArrayList ar)
        {
            string output = "";
            // reassemble string
            foreach (Char c in ar)
            {
                output += c;
            }
            // display output
            txtOutput.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
