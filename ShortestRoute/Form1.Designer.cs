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
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Node";
            // 
            // startingNodeLbl
            // 
            this.startingNodeLbl.AutoSize = true;
            this.startingNodeLbl.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingNodeLbl.Location = new System.Drawing.Point(102, 58);
            this.startingNodeLbl.Name = "startingNodeLbl";
            this.startingNodeLbl.Size = new System.Drawing.Size(24, 28);
            this.startingNodeLbl.TabIndex = 2;
            this.startingNodeLbl.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 63);
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
            this.endingNodeComboBox.Location = new System.Drawing.Point(195, 56);
            this.endingNodeComboBox.Name = "endingNodeComboBox";
            this.endingNodeComboBox.Size = new System.Drawing.Size(39, 31);
            this.endingNodeComboBox.TabIndex = 4;
            this.endingNodeComboBox.SelectedIndexChanged += new System.EventHandler(this.endingNodeComboBox_SelectedIndexChanged);
            // 
            // nodeValueNumeric
            // 
            this.nodeValueNumeric.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeValueNumeric.Location = new System.Drawing.Point(243, 57);
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
            this.addNodeBtn.Location = new System.Drawing.Point(291, 58);
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
            this.nextNodeBtn.Location = new System.Drawing.Point(354, 59);
            this.nextNodeBtn.Name = "nextNodeBtn";
            this.nextNodeBtn.Size = new System.Drawing.Size(98, 29);
            this.nextNodeBtn.TabIndex = 7;
            this.nextNodeBtn.Text = "Next Node";
            this.nextNodeBtn.UseVisualStyleBackColor = true;
            this.nextNodeBtn.Click += new System.EventHandler(this.nextNodeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 471);
            this.Controls.Add(this.nextNodeBtn);
            this.Controls.Add(this.addNodeBtn);
            this.Controls.Add(this.nodeValueNumeric);
            this.Controls.Add(this.endingNodeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startingNodeLbl);
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
    }
}

