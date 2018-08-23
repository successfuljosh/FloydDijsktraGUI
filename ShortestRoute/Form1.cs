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
        char[] nodeLabels = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        int nodelabelcounter = 0;
        SRModel graph = new SRModel();

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            nodes[Convert.ToChar(endingNodeComboBox.SelectedItem)] = (int)nodeValueNumeric.Value;
            MessageBox.Show($"Node {endingNodeComboBox.SelectedItem} added");
        }

        private void nextNodeBtn_Click(object sender, EventArgs e)
        {
            graph.Nodes[Convert.ToChar(startingNodeLbl.Text)] = nodes;
            nodelabelcounter++;
            startingNodeLbl.Text = nodeLabels[nodelabelcounter].ToString();
            collectionListbox.Items.Clear();
            foreach (var item in graph.Nodes)
            {
                foreach (var item2 in item.Value)
                {
                    var text = $"{item.Key} to {item2.Key} is {item2.Value}";
                    collectionListbox.Items.Add(text);
                }
            }
            nodes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dijisktraCostLabel.Text=graph.shortestRoute()
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
