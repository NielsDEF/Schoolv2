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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(5, 221);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btToevoegen.TabIndex = 0;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(210, 262);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 23);
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
            this.cbInput.Location = new System.Drawing.Point(25, 194);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(121, 21);
            this.cbInput.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labIngevoerd);
            this.groupBox1.Controls.Add(this.lbWagons);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lbIngevoerd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(172, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "resultaten";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Delete invoer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Totaal:";
            // 
            // labIngevoerd
            // 
            this.labIngevoerd.AutoSize = true;
            this.labIngevoerd.Location = new System.Drawing.Point(115, 246);
            this.labIngevoerd.Name = "labIngevoerd";
            this.labIngevoerd.Size = new System.Drawing.Size(37, 13);
            this.labIngevoerd.TabIndex = 14;
            this.labIngevoerd.Text = "Aantal";
            this.labIngevoerd.Visible = false;
            // 
            // lbWagons
            // 
            this.lbWagons.FormattingEnabled = true;
            this.lbWagons.Location = new System.Drawing.Point(210, 57);
            this.lbWagons.Name = "lbWagons";
            this.lbWagons.Size = new System.Drawing.Size(388, 186);
            this.lbWagons.TabIndex = 12;
            // 
            // lbIngevoerd
            // 
            this.lbIngevoerd.FormattingEnabled = true;
            this.lbIngevoerd.Location = new System.Drawing.Point(6, 57);
            this.lbIngevoerd.Name = "lbIngevoerd";
            this.lbIngevoerd.Size = new System.Drawing.Size(196, 186);
            this.lbIngevoerd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wagons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aantaldieren";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingevoerd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dieren toevoegen en verwijderen";
            // 
            // btVerwijderen
            // 
            this.btVerwijderen.Location = new System.Drawing.Point(86, 221);
            this.btVerwijderen.Name = "btVerwijderen";
            this.btVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btVerwijderen.TabIndex = 5;
            this.btVerwijderen.Text = "Verwijderen";
            this.btVerwijderen.UseVisualStyleBackColor = true;
            this.btVerwijderen.Click += new System.EventHandler(this.btVerwijderen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVerwijderen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbInput);
            this.Controls.Add(this.btToevoegen);
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
    }
}

