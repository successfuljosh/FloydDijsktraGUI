namespace ShortestRoute
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startingNodeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endingNodeComboBox = new System.Windows.Forms.ComboBox();
            this.nodeValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.addNodeBtn = new System.Windows.Forms.Button();
            this.nextNodeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.collectionListbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dijisktraCostLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startingNodecomboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.destinationNodecomboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nodeValueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shortest Route Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Node";
            // 
            // startingNodeLbl
            // 
            this.startingNodeLbl.AutoSize = true;
            this.startingNodeLbl.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingNodeLbl.Location = new System.Drawing.Point(102, 92);
            this.startingNodeLbl.Name = "startingNodeLbl";
            this.startingNodeLbl.Size = new System.Drawing.Size(24, 28);
            this.startingNodeLbl.TabIndex = 2;
            this.startingNodeLbl.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "to Node";
            // 
            // endingNodeComboBox
            // 
            this.endingNodeComboBox.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingNodeComboBox.FormattingEnabled = true;
            this.endingNodeComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.endingNodeComboBox.Location = new System.Drawing.Point(195, 90);
            this.endingNodeComboBox.Name = "endingNodeComboBox";
            this.endingNodeComboBox.Size = new System.Drawing.Size(39, 31);
            this.endingNodeComboBox.TabIndex = 4;
            // 
            // nodeValueNumeric
            // 
            this.nodeValueNumeric.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeValueNumeric.Location = new System.Drawing.Point(243, 91);
            this.nodeValueNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nodeValueNumeric.Name = "nodeValueNumeric";
            this.nodeValueNumeric.Size = new System.Drawing.Size(44, 28);
            this.nodeValueNumeric.TabIndex = 5;
            this.nodeValueNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addNodeBtn
            // 
            this.addNodeBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNodeBtn.Location = new System.Drawing.Point(291, 92);
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(57, 29);
            this.addNodeBtn.TabIndex = 6;
            this.addNodeBtn.Text = "Add";
            this.addNodeBtn.UseVisualStyleBackColor = true;
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // nextNodeBtn
            // 
            this.nextNodeBtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextNodeBtn.Location = new System.Drawing.Point(354, 93);
            this.nextNodeBtn.Name = "nextNodeBtn";
            this.nextNodeBtn.Size = new System.Drawing.Size(98, 29);
            this.nextNodeBtn.TabIndex = 7;
            this.nextNodeBtn.Text = "Next Node";
            this.nextNodeBtn.UseVisualStyleBackColor = true;
            this.nextNodeBtn.Click += new System.EventHandler(this.nextNodeBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // collectionListbox
            // 
            this.collectionListbox.FormattingEnabled = true;
            this.collectionListbox.Location = new System.Drawing.Point(16, 128);
            this.collectionListbox.Name = "collectionListbox";
            this.collectionListbox.Size = new System.Drawing.Size(394, 199);
            this.collectionListbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dijiskra\'s Path:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(143, 343);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(24, 28);
            this.c.TabIndex = 2;
            this.c.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dijiskra\'s Cost:";
            // 
            // dijisktraCostLabel
            // 
            this.dijisktraCostLabel.AutoSize = true;
            this.dijisktraCostLabel.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dijisktraCostLabel.Location = new System.Drawing.Point(143, 378);
            this.dijisktraCostLabel.Name = "dijisktraCostLabel";
            this.dijisktraCostLabel.Size = new System.Drawing.Size(24, 28);
            this.dijisktraCostLabel.TabIndex = 2;
            this.dijisktraCostLabel.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Starting Node:";
            // 
            // startingNodecomboBox1
            // 
            this.startingNodecomboBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingNodecomboBox1.FormattingEnabled = true;
            this.startingNodecomboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.startingNodecomboBox1.Location = new System.Drawing.Point(128, 52);
            this.startingNodecomboBox1.Name = "startingNodecomboBox1";
            this.startingNodecomboBox1.Size = new System.Drawing.Size(39, 31);
            this.startingNodecomboBox1.TabIndex = 4;
            this.startingNodecomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Destination Node:";
            // 
            // destinationNodecomboBox2
            // 
            this.destinationNodecomboBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationNodecomboBox2.FormattingEnabled = true;
            this.destinationNodecomboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.destinationNodecomboBox2.Location = new System.Drawing.Point(324, 52);
            this.destinationNodecomboBox2.Name = "destinationNodecomboBox2";
            this.destinationNodecomboBox2.Size = new System.Drawing.Size(39, 31);
            this.destinationNodecomboBox2.TabIndex = 4;
            this.destinationNodecomboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 471);
            this.Controls.Add(this.collectionListbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextNodeBtn);
            this.Controls.Add(this.addNodeBtn);
            this.Controls.Add(this.nodeValueNumeric);
            this.Controls.Add(this.destinationNodecomboBox2);
            this.Controls.Add(this.startingNodecomboBox1);
            this.Controls.Add(this.endingNodeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dijisktraCostLabel);
            this.Controls.Add(this.c);
            this.Controls.Add(this.startingNodeLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nodeValueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label startingNodeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox endingNodeComboBox;
        private System.Windows.Forms.NumericUpDown nodeValueNumeric;
        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.Button nextNodeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox collectionListbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dijisktraCostLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox startingNodecomboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox destinationNodecomboBox2;
    }
}

