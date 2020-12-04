namespace AlgoritmeCircus
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
            this.btToevoegen = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbInput = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labIngevoerd = new System.Windows.Forms.Label();
            this.lbWagons = new System.Windows.Forms.ListBox();
            this.lbIngevoerd = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btVerwijderen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(7, 272);
            this.btToevoegen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(100, 28);
            this.btToevoegen.TabIndex = 0;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(280, 322);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Vul wagons";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbInput
            // 
            this.cbInput.FormattingEnabled = true;
            this.cbInput.Items.AddRange(new object[] {
            "KV",
            "MV",
            "GV",
            "KP",
            "MP",
            "GP"});
            this.cbInput.Location = new System.Drawing.Point(33, 239);
            this.cbInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(160, 24);
            this.cbInput.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labIngevoerd);
            this.groupBox1.Controls.Add(this.lbWagons);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lbIngevoerd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(229, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(821, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "resultaten";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "Delete invoer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Totaal:";
            // 
            // labIngevoerd
            // 
            this.labIngevoerd.AutoSize = true;
            this.labIngevoerd.Location = new System.Drawing.Point(153, 303);
            this.labIngevoerd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labIngevoerd.Name = "labIngevoerd";
            this.labIngevoerd.Size = new System.Drawing.Size(48, 17);
            this.labIngevoerd.TabIndex = 14;
            this.labIngevoerd.Text = "Aantal";
            this.labIngevoerd.Visible = false;
            // 
            // lbWagons
            // 
            this.lbWagons.FormattingEnabled = true;
            this.lbWagons.ItemHeight = 16;
            this.lbWagons.Location = new System.Drawing.Point(280, 70);
            this.lbWagons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbWagons.Name = "lbWagons";
            this.lbWagons.Size = new System.Drawing.Size(516, 228);
            this.lbWagons.TabIndex = 12;
            // 
            // lbIngevoerd
            // 
            this.lbIngevoerd.FormattingEnabled = true;
            this.lbIngevoerd.ItemHeight = 16;
            this.lbIngevoerd.Location = new System.Drawing.Point(8, 70);
            this.lbIngevoerd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbIngevoerd.Name = "lbIngevoerd";
            this.lbIngevoerd.Size = new System.Drawing.Size(260, 228);
            this.lbIngevoerd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wagons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aantaldieren";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingevoerd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dieren toevoegen en verwijderen";
            // 
            // btVerwijderen
            // 
            this.btVerwijderen.Location = new System.Drawing.Point(115, 272);
            this.btVerwijderen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVerwijderen.Name = "btVerwijderen";
            this.btVerwijderen.Size = new System.Drawing.Size(100, 28);
            this.btVerwijderen.TabIndex = 5;
            this.btVerwijderen.Text = "Verwijderen";
            this.btVerwijderen.UseVisualStyleBackColor = true;
            this.btVerwijderen.Click += new System.EventHandler(this.btVerwijderen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 29;
            this.button2.Text = "Empty wagons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btVerwijderen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbInput);
            this.Controls.Add(this.btToevoegen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btToevoegen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbIngevoerd;
        private System.Windows.Forms.ListBox lbWagons;
        private System.Windows.Forms.Button btVerwijderen;
        private System.Windows.Forms.Label labIngevoerd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

