using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestRoute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<char, int> nodes = new Dictionary<char, int>();

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            nodes[Convert.ToChar(endingNodeComboBox.SelectedItem)] = (int)nodeValueNumeric.Value;
        }

        private void nextNodeBtn_Click(object sender, EventArgs e)
        {

        }

        private void endingNodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
