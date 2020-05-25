using System;
using System.Windows.Forms;

namespace KeygenForCrackMe14
{
    public partial class KeygenForCrackMe14 : Form
    {
        private string name;
        public string input;

        public KeygenForCrackMe14()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Crack_Click(object sender, EventArgs e)
        {
            // Assign string keyname the value of first 4 characters in First Name inputbox 
            string keyname = GetName();

            // Check if the Name is less than 4 if so exit function.
            if (keyname.Length < 4)
            {
                return;
            }

            // If key is greater than or = to 4 Generate the key. --- This is always true because I assigned KeyG to any input less than 4
            else
            {
                // Blank label for the string generation -- Could also use an input box so it would be selectable. 
                label4.Text = GenerateKey(keyname);
            }            
        }

        private string GetName()
        {
            // Set the textbox string length
            textBox1.MaxLength = 12;

            // Assign textbox input to string input
            input = textBox1.Text;

            // Check min and max length
            if (input.Length >= 4 && input.Length <= textBox1.MaxLength)
            {
                // Get the first 4 characters of the string input and assign it to the name string
                return name = input.Substring(0, 4);
            }

            // Instead of returning send a 4 character string.
            return "KeyG";
        }

        private string GenerateKey(string name)
        {
            // Key is the first 4 characters of a name plus the key 3254525
            return (name + "-" + "3254525");
        }
    }
}
