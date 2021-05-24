namespace ims
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.barCodeTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.grossLabel = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.changeGivenTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totDiscountTxt = new System.Windows.Forms.TextBox();
            this.grossTxt = new System.Windows.Forms.TextBox();
            this.payDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.panel6);
            this.leftPanel.Controls.Add(this.panel5);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel5, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel6, 0);
            this.leftPanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel4);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Barcode";
            // 
            // barCodeTxt
            // 
            this.barCodeTxt.Location = new System.Drawing.Point(4, 3);
            this.barCodeTxt.MaxLength = 100;
            this.barCodeTxt.Name = "barCodeTxt";
            this.barCodeTxt.Size = new System.Drawing.Size(243, 23);
            this.barCodeTxt.TabIndex = 2;
            this.barCodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barCodeTxt_KeyDown_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.proIDGV,
            this.proGV,
            this.quantGV,
            this.pupGV,
            this.discGV,
            this.TotGV,
            this.deleteGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 390);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 69);
            this.panel4.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.79503F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.20497F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grossLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(805, 69);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(579, 69);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gross Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grossLabel
            // 
            this.grossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.Location = new System.Drawing.Point(588, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(214, 69);
            this.grossLabel.TabIndex = 13;
            this.grossLabel.Text = "0.00";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.IndianRed;
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderSize = 2;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Location = new System.Drawing.Point(6, 350);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(237, 66);
            this.payBtn.TabIndex = 3;
            this.payBtn.Text = "&PAY";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkoutBtn);
            this.groupBox2.Controls.Add(this.changeGivenTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.amountTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.totDiscountTxt);
            this.groupBox2.Controls.Add(this.grossTxt);
            this.groupBox2.Controls.Add(this.payDD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.payBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 428);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payments";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.IndianRed;
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.FlatAppearance.BorderSize = 2;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Location = new System.Drawing.Point(7, 284);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(237, 60);
            this.checkoutBtn.TabIndex = 13;
            this.checkoutBtn.Text = "&CHECKOUT";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // changeGivenTxt
            // 
            this.changeGivenTxt.Enabled = false;
            this.changeGivenTxt.Location = new System.Drawing.Point(6, 255);
            this.changeGivenTxt.MaxLength = 100;
            this.changeGivenTxt.Name = "changeGivenTxt";
            this.changeGivenTxt.Size = new System.Drawing.Size(240, 23);
            this.changeGivenTxt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Change To Give";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(6, 208);
            this.amountTxt.MaxLength = 100;
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(240, 23);
            this.amountTxt.TabIndex = 10;
            this.amountTxt.TextChanged += new System.EventHandler(this.amountTxt_TextChanged);
            this.amountTxt.Validating += new System.ComponentModel.CancelEventHandler(this.amountTxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount Given";
            // 
            // totDiscountTxt
            // 
            this.totDiscountTxt.Enabled = false;
            this.totDiscountTxt.Location = new System.Drawing.Point(6, 101);
            this.totDiscountTxt.MaxLength = 100;
            this.totDiscountTxt.Name = "totDiscountTxt";
            this.totDiscountTxt.Size = new System.Drawing.Size(240, 23);
            this.totDiscountTxt.TabIndex = 8;
            // 
            // grossTxt
            // 
            this.grossTxt.Enabled = false;
            this.grossTxt.Location = new System.Drawing.Point(6, 49);
            this.grossTxt.MaxLength = 100;
            this.grossTxt.Name = "grossTxt";
            this.grossTxt.Size = new System.Drawing.Size(241, 23);
            this.grossTxt.TabIndex = 3;
            // 
            // payDD
            // 
            this.payDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payDD.FormattingEnabled = true;
            this.payDD.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.payDD.Location = new System.Drawing.Point(6, 155);
            this.payDD.Name = "payDD";
            this.payDD.Size = new System.Drawing.Size(241, 23);
            this.payDD.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = " Total Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gross Total";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 49);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.barCodeTxt);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 31);
            this.panel6.TabIndex = 6;
            // 
            // proIDGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proIDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Product";
            this.proGV.Name = "proGV";
            this.proGV.ReadOnly = true;
            this.proGV.Width = 201;
            // 
            // quantGV
            // 
            this.quantGV.HeaderText = "Quantity";
            this.quantGV.Name = "quantGV";
            this.quantGV.ReadOnly = true;
            this.quantGV.Width = 201;
            // 
            // pupGV
            // 
            this.pupGV.HeaderText = "Per Unit Price";
            this.pupGV.Name = "pupGV";
            this.pupGV.ReadOnly = true;
            this.pupGV.Width = 201;
            // 
            // discGV
            // 
            this.discGV.HeaderText = "Discount";
            this.discGV.Name = "discGV";
            this.discGV.ReadOnly = true;
            // 
            // TotGV
            // 
            this.TotGV.HeaderText = "Total Amount";
            this.TotGV.Name = "TotGV";
            this.TotGV.ReadOnly = true;
            this.TotGV.Width = 201;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 555);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load_1);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox barCodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.TextBox changeGivenTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totDiscountTxt;
        private System.Windows.Forms.TextBox grossTxt;
        private System.Windows.Forms.ComboBox payDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;

    }
}