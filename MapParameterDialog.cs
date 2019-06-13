using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelMapEditor
{
    public partial class MapParameterDialog : Form
    {
        public MapParameterDialog()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            try
            {
                Form1.MapWidth = Int32.Parse(textBox1.Text);
                Form1.MapHeight = Int32.Parse(textBox2.Text);
                this.Close();
            }
            catch(FormatException)
            {
                ErrorProvider.SetError(Done, "You did not enter a valid width and/or height!");
            }
        }
    }
}
