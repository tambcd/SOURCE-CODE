namespace OutlookDemo.UserControls
{
    partial class UserControlGiangVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSumtime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelSumTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bxGV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridGV = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbcBoMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbcBoMon);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.txtMoney);
            this.panel1.Controls.Add(this.labelMoney);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.txtSumtime);
            this.panel1.Controls.Add(this.LabelSumTime);
            this.panel1.Controls.Add(this.bxGV);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 67);
            this.panel1.TabIndex = 7;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1323, 5);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(125, 37);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "In báo cáo";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.Transparent;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(847, 15);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(14, 24);
            this.txtMoney.TabIndex = 22;
            this.txtMoney.Text = "0";
            this.txtMoney.Visible = false;
            this.txtMoney.Click += new System.EventHandler(this.txtMoney_Click);
            // 
            // labelMoney
            // 
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(747, 14);
            this.labelMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(94, 24);
            this.labelMoney.TabIndex = 21;
            this.labelMoney.Text = "Tổng tiền:";
            this.labelMoney.Visible = false;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.Transparent;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(664, 14);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(14, 24);
            this.txt_price.TabIndex = 20;
            this.txt_price.Text = "0";
            this.txt_price.Visible = false;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(580, 14);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(78, 24);
            this.price.TabIndex = 19;
            this.price.Text = "Đơn giá:";
            this.price.Visible = false;
            // 
            // txtSumtime
            // 
            this.txtSumtime.BackColor = System.Drawing.Color.Transparent;
            this.txtSumtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumtime.Location = new System.Drawing.Point(484, 14);
            this.txtSumtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSumtime.Name = "txtSumtime";
            this.txtSumtime.Size = new System.Drawing.Size(14, 24);
            this.txtSumtime.TabIndex = 18;
            this.txtSumtime.Text = "0";
            this.txtSumtime.Visible = false;
            // 
            // LabelSumTime
            // 
            this.LabelSumTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelSumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSumTime.Location = new System.Drawing.Point(444, 14);
            this.LabelSumTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelSumTime.Name = "LabelSumTime";
            this.LabelSumTime.Size = new System.Drawing.Size(34, 24);
            this.LabelSumTime.TabIndex = 17;
            this.LabelSumTime.Text = "Giờ";
            this.LabelSumTime.Visible = false;
            // 
            // bxGV
            // 
            this.bxGV.BackColor = System.Drawing.Color.Transparent;
            this.bxGV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bxGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bxGV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bxGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bxGV.ItemHeight = 30;
            this.bxGV.Location = new System.Drawing.Point(250, 7);
            this.bxGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bxGV.Name = "bxGV";
            this.bxGV.Size = new System.Drawing.Size(188, 36);
            this.bxGV.TabIndex = 15;
            this.bxGV.Visible = false;
            this.bxGV.SelectedIndexChanged += new System.EventHandler(this.bxGV_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1182, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1461, 721);
            this.panel2.TabIndex = 8;
            // 
            // gridGV
            // 
            this.gridGV.AllowDrop = true;
            this.gridGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridGV.EnableHeadersVisualStyles = false;
            this.gridGV.Location = new System.Drawing.Point(0, 0);
            this.gridGV.Margin = new System.Windows.Forms.Padding(4);
            this.gridGV.Name = "gridGV";
            this.gridGV.ReadOnly = true;
            this.gridGV.RowHeadersWidth = 30;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.gridGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridGV.Size = new System.Drawing.Size(1461, 721);
            this.gridGV.TabIndex = 0;
            // 
            // cbcBoMon
            // 
            this.cbcBoMon.BackColor = System.Drawing.Color.Transparent;
            this.cbcBoMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbcBoMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcBoMon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcBoMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcBoMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbcBoMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbcBoMon.ItemHeight = 30;
            this.cbcBoMon.Location = new System.Drawing.Point(6, 5);
            this.cbcBoMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcBoMon.Name = "cbcBoMon";
            this.cbcBoMon.Size = new System.Drawing.Size(225, 36);
            this.cbcBoMon.TabIndex = 24;
            this.cbcBoMon.Visible = false;
            // 
            // UserControlGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "UserControlGiangVien";
            this.Size = new System.Drawing.Size(1461, 788);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView gridGV;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel price;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelSumTime;
        public Guna.UI2.WinForms.Guna2ComboBox bxGV;
        public Guna.UI2.WinForms.Guna2HtmlLabel txtSumtime;
        public Guna.UI2.WinForms.Guna2HtmlLabel txt_price;
        public Guna.UI2.WinForms.Guna2HtmlLabel txtMoney;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public Guna.UI2.WinForms.Guna2ComboBox cbcBoMon;
    }
}
