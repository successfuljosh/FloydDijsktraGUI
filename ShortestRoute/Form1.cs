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
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;

        }

        Dictionary<char, int> nodes = new Dictionary<char, int>();
        char[] nodeLabels = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        int nodelabelcounter = 0;
        SRModel graph = new SRModel();

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            nodes[Convert.ToChar(endingNodeComboBox.SelectedItem)] = (int)nodeValueNumeric.Value;
            MessageBox.Show($"Node {endingNodeComboBox.SelectedItem} added");
            collectionListbox.Items.Clear();
            foreach (var item in nodes)
            {
                collectionListbox.Items.Add($"{startingNodeLbl.Text} to {item.Key} = {item.Value}");
            }
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
            nodes = new Dictionary<char, int>();
            endingNodeComboBox.SelectedItem = "A";
            nodeValueNumeric.Value = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //  dijisktraCostLabel.Text = graph.shortestRoute('A','D').FirstOrDefault().Value.ToString();
            dijisktraCostLabel.Text = graph.shortestRoute(Convert.ToChar(startingNodecomboBox1.SelectedItem), Convert.ToChar(destinationNodecomboBox2.SelectedItem)).FirstOrDefault().Value.ToString();

            dijisktraPathtxt.Text = $"Start --> {startingNodecomboBox1.SelectedItem} --> ";
            foreach (var item in graph.shortestRoute(Convert.ToChar(startingNodecomboBox1.SelectedItem.ToString()), Convert.ToChar(destinationNodecomboBox2.SelectedItem.ToString())).Reverse())
            {
                dijisktraPathtxt.Text += $"{item.Key} --> ";

            }
            dijisktraPathtxt.Text += "End";

            //FLOYD'S PART
            for (int i = 0; i < destinationNodecomboBox2.SelectedIndex + 1; i++)
            {
                dataGridView1.Columns.Add(nodeLabels[i].ToString(), nodeLabels[i].ToString());
            }
            dataGridView1.Rows.Add(destinationNodecomboBox2.SelectedIndex + 1);

            for (int i = 0; i < destinationNodecomboBox2.SelectedIndex + 1; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = nodeLabels[i].ToString();

                for (int j = 0; j < destinationNodecomboBox2.SelectedIndex + 1; j++)
                {
                    if (i == j)
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    else
                        dataGridView1.Rows[i].Cells[j].Value = graph.shortestRoute(Convert.ToChar(dataGridView1.Rows[i].HeaderCell.Value.ToString()), Convert.ToChar(dataGridView1.Columns[j].HeaderText)).FirstOrDefault().Value;
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            endingNodeComboBox.Items.Clear();

            foreach (var item in nodeLabels.Take(destinationNodecomboBox2.SelectedIndex + 1))
            {
                endingNodeComboBox.Items.Add(item);
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This will clear the application memory","Are you sure",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                graph = new SRModel();
                endingNodeComboBox.Items.Clear();
                dataGridView1.ColumnCount = 0;
                dataGridView1.RowCount = 0;
                collectionListbox.Items.Clear();
                dijisktraPathtxt.Clear();
                dijisktraCostLabel.Text = "";
                nodelabelcounter = 0;
                startingNodeLbl.Text = "A";
            }
        }
    }
}
