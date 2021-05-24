namespace ims
{
    partial class PurchaseInvoice
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
            this.supplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.quanTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pupTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totLabel = new System.Windows.Forms.Label();
            this.suppErrorLabel = new System.Windows.Forms.Label();
            this.barErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.grossLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.totLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.cartBtn);
            this.leftPanel.Controls.Add(this.pupTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.quanTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.productTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.supplierDD);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.suppErrorLabel);
            this.leftPanel.Controls.Add(this.barErrorLabel);
            this.leftPanel.Controls.Add(this.quantityErrorLabel);
            this.leftPanel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.quantityErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.barErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.suppErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.quanTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.pupTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.cartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.totLabel, 0);
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
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Supplier";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // supplierDD
            // 
            this.supplierDD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierDD.FormattingEnabled = true;
            this.supplierDD.Location = new System.Drawing.Point(4, 104);
            this.supplierDD.Name = "supplierDD";
            this.supplierDD.Size = new System.Drawing.Size(229, 23);
            this.supplierDD.TabIndex = 0;
            this.supplierDD.SelectedIndexChanged += new System.EventHandler(this.supplierDD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = " Product";
            // 
            // productTxt
            // 
            this.productTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTxt.Location = new System.Drawing.Point(3, 213);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(229, 23);
            this.productTxt.TabIndex = 2;
            this.productTxt.TextChanged += new System.EventHandler(this.productTxt_TextChanged);
            // 
            // quanTxt
            // 
            this.quanTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanTxt.Location = new System.Drawing.Point(3, 323);
            this.quanTxt.Name = "quanTxt";
            this.quanTxt.Size = new System.Drawing.Size(229, 23);
            this.quanTxt.TabIndex = 4;
            this.quanTxt.TextChanged += new System.EventHandler(this.quanTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTxt.Location = new System.Drawing.Point(3, 158);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(229, 23);
            this.barcodeTxt.TabIndex = 1;
            this.barcodeTxt.TextChanged += new System.EventHandler(this.barcodeTxt_TextChanged);
            this.barcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTxt_Validating);
            this.barcodeTxt.Validated += new System.EventHandler(this.barcodeTxt_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Barcode";
            // 
            // pupTxt
            // 
            this.pupTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupTxt.Location = new System.Drawing.Point(3, 268);
            this.pupTxt.Name = "pupTxt";
            this.pupTxt.Size = new System.Drawing.Size(229, 23);
            this.pupTxt.TabIndex = 3;
            this.pupTxt.TextChanged += new System.EventHandler(this.pupTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Per Unit Price";
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
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // cartBtn
            // 
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.FlatAppearance.BorderSize = 2;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.Location = new System.Drawing.Point(4, 365);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(228, 34);
            this.cartBtn.TabIndex = 5;
            this.cartBtn.Text = "ADD TO CART";
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Amount";
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLabel.Location = new System.Drawing.Point(99, 439);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(81, 46);
            this.totLabel.TabIndex = 11;
            this.totLabel.Text = "0.00";
            // 
            // suppErrorLabel
            // 
            this.suppErrorLabel.AutoSize = true;
            this.suppErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.suppErrorLabel.Location = new System.Drawing.Point(92, 82);
            this.suppErrorLabel.Name = "suppErrorLabel";
            this.suppErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.suppErrorLabel.TabIndex = 15;
            this.suppErrorLabel.Text = "*";
            this.suppErrorLabel.Visible = false;
            // 
            // barErrorLabel
            // 
            this.barErrorLabel.AutoSize = true;
            this.barErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.barErrorLabel.Location = new System.Drawing.Point(52, 136);
            this.barErrorLabel.Name = "barErrorLabel";
            this.barErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.barErrorLabel.TabIndex = 16;
            this.barErrorLabel.Text = "*";
            this.barErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.quantityErrorLabel.Location = new System.Drawing.Point(93, 301);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(20, 28);
            this.quantityErrorLabel.TabIndex = 17;
            this.quantityErrorLabel.Text = "*";
            this.quantityErrorLabel.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 69);
            this.panel4.TabIndex = 6;
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
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 555);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox supplierDD;
        private System.Windows.Forms.TextBox quanTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pupTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label suppErrorLabel;
        private System.Windows.Forms.Label barErrorLabel;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}