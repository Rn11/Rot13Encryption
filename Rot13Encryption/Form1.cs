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
            // get the input of the field
            ArrayList input = new ArrayList();
            // fill array with input field
            for (int i = 0; i < txtInput.TextLength; i++)
            {
                input.Add(txtInput.Text[i].ToString().ToLower());
            }
            return input;
        }

        private void rot13()
        {
            // Actual Rot13 algorithm
            ArrayList input = getInput();
            for (int i = 0; i < input.Count; i++)
            {
                // convert current letter to char
                char c = Convert.ToChar(input[i]);
                // increment char by 13
                // check if current char is between 65-122 (= a letter)
                if (c >= 65 && c <= 122)
                {
                    input[i] = c = (char)('a' + (c - 'a' + 13) % 26);
                }
                else
                {
                    input[i] = c;
                }
            }
            showResult(input);
        }

        private void showResult(ArrayList ar)
        {
            string output = "";
            // reassemble string
            foreach (Char c in ar)
            {
                output += c;
            }
            output.ToLower();
            // display output
            txtOutput.Text = output;
        }

        // Eventlistener for Enter-key
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rot13();
            }
        }

        // Eventlistener for input
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            rot13();
        }
    }
}
