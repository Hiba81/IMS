namespace ims
{
    partial class Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierCompanyTxt = new System.Windows.Forms.TextBox();
            this.personNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone1Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone2Txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ntnTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.supNameErrorLabel = new System.Windows.Forms.Label();
            this.contactPersonErrorLabel = new System.Windows.Forms.Label();
            this.Phone1ErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label13);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Controls.Add(this.ntnTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.addressTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.Phone2Txt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.Phone1Txt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.personNameTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.supplierCompanyTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.supNameErrorLabel);
            this.leftPanel.Controls.Add(this.contactPersonErrorLabel);
            this.leftPanel.Controls.Add(this.Phone1ErrorLabel);
            this.leftPanel.Controls.Add(this.addressErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.addressErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.Phone1ErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactPersonErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.supNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierCompanyTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.personNameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.Phone1Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.Phone2Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.ntnTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label13, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name/Company";
            // 
            // supplierCompanyTxt
            // 
            this.supplierCompanyTxt.Location = new System.Drawing.Point(3, 100);
            this.supplierCompanyTxt.MaxLength = 100;
            this.supplierCompanyTxt.Name = "supplierCompanyTxt";
            this.supplierCompanyTxt.Size = new System.Drawing.Size(229, 23);
            this.supplierCompanyTxt.TabIndex = 2;
            // 
            // personNameTxt
            // 
            this.personNameTxt.Location = new System.Drawing.Point(3, 150);
            this.personNameTxt.MaxLength = 100;
            this.personNameTxt.Name = "personNameTxt";
            this.personNameTxt.Size = new System.Drawing.Size(229, 23);
            this.personNameTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Person";
            // 
            // Phone1Txt
            // 
            this.Phone1Txt.Location = new System.Drawing.Point(3, 200);
            this.Phone1Txt.MaxLength = 15;
            this.Phone1Txt.Name = "Phone1Txt";
            this.Phone1Txt.Size = new System.Drawing.Size(229, 23);
            this.Phone1Txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone 1";
            // 
            // Phone2Txt
            // 
            this.Phone2Txt.Location = new System.Drawing.Point(3, 252);
            this.Phone2Txt.MaxLength = 15;
            this.Phone2Txt.Name = "Phone2Txt";
            this.Phone2Txt.Size = new System.Drawing.Size(229, 23);
            this.Phone2Txt.TabIndex = 8;
            this.Phone2Txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone 2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(3, 307);
            this.addressTxt.MaxLength = 100;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(229, 23);
            this.addressTxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // ntnTxt
            // 
            this.ntnTxt.Location = new System.Drawing.Point(3, 359);
            this.ntnTxt.MaxLength = 15;
            this.ntnTxt.Name = "ntnTxt";
            this.ntnTxt.Size = new System.Drawing.Size(229, 23);
            this.ntnTxt.TabIndex = 12;
            this.ntnTxt.TextChanged += new System.EventHandler(this.ntnTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "NTN#";
            // 
            // supNameErrorLabel
            // 
            this.supNameErrorLabel.AutoSize = true;
            this.supNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.supNameErrorLabel.Location = new System.Drawing.Point(144, 79);
            this.supNameErrorLabel.Name = "supNameErrorLabel";
            this.supNameErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.supNameErrorLabel.TabIndex = 16;
            this.supNameErrorLabel.Text = "*";
            this.supNameErrorLabel.Visible = false;
            // 
            // contactPersonErrorLabel
            // 
            this.contactPersonErrorLabel.AutoSize = true;
            this.contactPersonErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPersonErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.contactPersonErrorLabel.Location = new System.Drawing.Point(89, 128);
            this.contactPersonErrorLabel.Name = "contactPersonErrorLabel";
            this.contactPersonErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.contactPersonErrorLabel.TabIndex = 17;
            this.contactPersonErrorLabel.Text = "*";
            this.contactPersonErrorLabel.Visible = false;
            // 
            // Phone1ErrorLabel
            // 
            this.Phone1ErrorLabel.AutoSize = true;
            this.Phone1ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1ErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.Phone1ErrorLabel.Location = new System.Drawing.Point(55, 178);
            this.Phone1ErrorLabel.Name = "Phone1ErrorLabel";
            this.Phone1ErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.Phone1ErrorLabel.TabIndex = 18;
            this.Phone1ErrorLabel.Text = "*";
            this.Phone1ErrorLabel.Visible = false;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.addressErrorLabel.Location = new System.Drawing.Point(52, 285);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.addressErrorLabel.TabIndex = 20;
            this.addressErrorLabel.Text = "*";
            this.addressErrorLabel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Status";
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrorLabel.Location = new System.Drawing.Point(42, 386);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.statusErrorLabel.TabIndex = 24;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(3, 409);
            this.statusDD.MaxLength = 100;
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(229, 23);
            this.statusDD.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppIDGV,
            this.companyGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 459);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "suppID";
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Contact Person";
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone 2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 555);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplierCompanyTxt;
        private System.Windows.Forms.TextBox ntnTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone2Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone1Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.Label supNameErrorLabel;
        private System.Windows.Forms.Label contactPersonErrorLabel;
        private System.Windows.Forms.Label Phone1ErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}