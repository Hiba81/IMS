namespace ims
{
    partial class SalesReturnWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.salesIDTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerProductDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perproducttotalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldiscGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountreturnedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.userTXt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.payTxt = new System.Windows.Forms.TextBox();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.amountrefundTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.leftPanel.Controls.Add(this.amountrefundTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.payTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.userTXt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.dateTimePicker1);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.LoadBtn);
            this.leftPanel.Controls.Add(this.salesIDTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.salesIDTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.LoadBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTXt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.payTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.amountrefundTxt, 0);
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
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Sales ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // salesIDTxt
            // 
            this.salesIDTxt.Location = new System.Drawing.Point(4, 112);
            this.salesIDTxt.Name = "salesIDTxt";
            this.salesIDTxt.Size = new System.Drawing.Size(230, 23);
            this.salesIDTxt.TabIndex = 2;
            this.salesIDTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salesIDTxt_KeyDown);
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
            this.SaleIDGV,
            this.barcodeGV,
            this.productGV,
            this.quantityGV,
            this.priceGV,
            this.PerProductDiscountGV,
            this.perproducttotalGV,
            this.totaldiscGV,
            this.totalAmountGV,
            this.AmountGivenGV,
            this.AmountreturnedGV,
            this.dateGV,
            this.proidGV,
            this.paymentGV,
            this.UserGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 459);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SaleIDGV
            // 
            this.SaleIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleIDGV.HeaderText = "SaleID";
            this.SaleIDGV.Name = "SaleIDGV";
            this.SaleIDGV.ReadOnly = true;
            this.SaleIDGV.Visible = false;
            // 
            // barcodeGV
            // 
            this.barcodeGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // productGV
            // 
            this.productGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // PerProductDiscountGV
            // 
            this.PerProductDiscountGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.PerProductDiscountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PerProductDiscountGV.HeaderText = "Per Product Discount";
            this.PerProductDiscountGV.Name = "PerProductDiscountGV";
            this.PerProductDiscountGV.ReadOnly = true;
            this.PerProductDiscountGV.Visible = false;
            // 
            // perproducttotalGV
            // 
            this.perproducttotalGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.perproducttotalGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.perproducttotalGV.HeaderText = "Per Product Total";
            this.perproducttotalGV.Name = "perproducttotalGV";
            this.perproducttotalGV.ReadOnly = true;
            // 
            // totaldiscGV
            // 
            this.totaldiscGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totaldiscGV.HeaderText = "Total Discount";
            this.totaldiscGV.Name = "totaldiscGV";
            this.totaldiscGV.ReadOnly = true;
            this.totaldiscGV.Visible = false;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            this.totalAmountGV.Visible = false;
            // 
            // AmountGivenGV
            // 
            this.AmountGivenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountGivenGV.HeaderText = "Amount Given";
            this.AmountGivenGV.Name = "AmountGivenGV";
            this.AmountGivenGV.ReadOnly = true;
            this.AmountGivenGV.Visible = false;
            // 
            // AmountreturnedGV
            // 
            this.AmountreturnedGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountreturnedGV.HeaderText = "Amount Returned";
            this.AmountreturnedGV.Name = "AmountreturnedGV";
            this.AmountreturnedGV.ReadOnly = true;
            this.AmountreturnedGV.Visible = false;
            // 
            // dateGV
            // 
            this.dateGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            this.dateGV.Visible = false;
            // 
            // proidGV
            // 
            this.proidGV.HeaderText = "Pro ID";
            this.proidGV.Name = "proidGV";
            this.proidGV.ReadOnly = true;
            this.proidGV.Visible = false;
            // 
            // paymentGV
            // 
            this.paymentGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentGV.HeaderText = "Payment";
            this.paymentGV.Name = "paymentGV";
            this.paymentGV.ReadOnly = true;
            this.paymentGV.Visible = false;
            // 
            // UserGV
            // 
            this.UserGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserGV.HeaderText = "User";
            this.UserGV.Name = "UserGV";
            this.UserGV.ReadOnly = true;
            this.UserGV.Visible = false;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.IndianRed;
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadBtn.FlatAppearance.BorderSize = 2;
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.Location = new System.Drawing.Point(7, 141);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(227, 40);
            this.LoadBtn.TabIndex = 14;
            this.LoadBtn.Text = "&Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMMM-yyyy hh:mm:ss tt";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "User";
            // 
            // userTXt
            // 
            this.userTXt.Enabled = false;
            this.userTXt.Location = new System.Drawing.Point(6, 256);
            this.userTXt.Name = "userTXt";
            this.userTXt.Size = new System.Drawing.Size(228, 23);
            this.userTXt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Payment Type";
            // 
            // payTxt
            // 
            this.payTxt.Enabled = false;
            this.payTxt.Location = new System.Drawing.Point(6, 306);
            this.payTxt.Name = "payTxt";
            this.payTxt.Size = new System.Drawing.Size(228, 23);
            this.payTxt.TabIndex = 20;
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(7, 356);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(228, 23);
            this.barcodeTxt.TabIndex = 22;
            this.barcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeTxt_KeyDown);
            this.barcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter Barcode";
            // 
            // amountrefundTxt
            // 
            this.amountrefundTxt.Enabled = false;
            this.amountrefundTxt.Location = new System.Drawing.Point(6, 405);
            this.amountrefundTxt.Name = "amountrefundTxt";
            this.amountrefundTxt.Size = new System.Drawing.Size(228, 23);
            this.amountrefundTxt.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Amount To Refund";
            // 
            // SalesReturnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 555);
            this.Name = "SalesReturnWindow";
            this.Text = "Sales Return Window";
            this.Load += new System.EventHandler(this.SalesReturnWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox salesIDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.TextBox payTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userTXt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerProductDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perproducttotalGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldiscGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountreturnedGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGV;
        private System.Windows.Forms.TextBox amountrefundTxt;
        private System.Windows.Forms.Label label7;
    }
}