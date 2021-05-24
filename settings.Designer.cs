namespace ims
{
    partial class settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.userTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.databaseTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.serverTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(250, 555);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(3, 263);
            this.serverTxt.MaxLength = 50;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(232, 23);
            this.serverTxt.TabIndex = 2;
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(3, 314);
            this.databaseTxt.MaxLength = 50;
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(232, 23);
            this.databaseTxt.TabIndex = 4;
            this.databaseTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(3, 366);
            this.userTxt.MaxLength = 30;
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(232, 23);
            this.userTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(3, 420);
            this.passTxt.MaxLength = 30;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(232, 23);
            this.passTxt.TabIndex = 8;
            this.passTxt.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(3, 450);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(125, 19);
            this.isCB.TabIndex = 9;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(3, 476);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(232, 29);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 555);
            this.Name = "settings";
            this.Text = "settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox isCB;
    }
}