namespace WFQuanLyNhanVien
{
    partial class FrmPhongBan
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
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaDiemPB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgNhanChuc = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDiscard2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnDel2 = new System.Windows.Forms.Button();
            this.btnReload2 = new System.Windows.Forms.Button();
            this.dgvDDPB = new System.Windows.Forms.DataGridView();
            this.MaPB1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.AllowUserToOrderColumns = true;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB,
            this.TenPB,
            this.TrPhong,
            this.NgNhanChuc});
            this.dgvPhongBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPhongBan.Location = new System.Drawing.Point(2, 2);
            this.dgvPhongBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.RowHeadersWidth = 62;
            this.dgvPhongBan.RowTemplate.Height = 28;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(854, 513);
            this.dgvPhongBan.TabIndex = 1;
            this.dgvPhongBan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentDoubleClick);
            this.dgvPhongBan.SelectionChanged += new System.EventHandler(this.dgvPhongBang_OnSelectionChanged);
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPB";
            this.MaPB.FillWeight = 60F;
            this.MaPB.HeaderText = "Mã PB";
            this.MaPB.MinimumWidth = 8;
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.HeaderText = "Tên PB";
            this.TenPB.MinimumWidth = 8;
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            // 
            // TrPhong
            // 
            this.TrPhong.DataPropertyName = "TrPhong";
            this.TrPhong.HeaderText = "Trưởng Phòng";
            this.TrPhong.MinimumWidth = 8;
            this.TrPhong.Name = "TrPhong";
            this.TrPhong.ReadOnly = true;
            // 
            // NgNhanChuc
            // 
            this.NgNhanChuc.DataPropertyName = "NgNhanChuc";
            this.NgNhanChuc.HeaderText = "Ngày Nhận Chức";
            this.NgNhanChuc.MinimumWidth = 8;
            this.NgNhanChuc.Name = "NgNhanChuc";
            this.NgNhanChuc.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Location = new System.Drawing.Point(860, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 513);
            this.panel1.TabIndex = 24;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Enabled = false;
            this.btnDiscard.Location = new System.Drawing.Point(16, 228);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(80, 40);
            this.btnDiscard.TabIndex = 18;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(16, 158);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 88);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.Location = new System.Drawing.Point(16, 358);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 40);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(16, 293);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 40);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDiaDiemPB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTrPhong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMaPB);
            this.panel2.Controls.Add(this.txtTenPB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNgNhanChuc);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Location = new System.Drawing.Point(2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 115);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Địa Điểm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDiaDiemPB
            // 
            this.txtDiaDiemPB.Location = new System.Drawing.Point(303, 36);
            this.txtDiaDiemPB.Name = "txtDiaDiemPB";
            this.txtDiaDiemPB.Size = new System.Drawing.Size(100, 20);
            this.txtDiaDiemPB.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Trưởng Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ngày Nhận Chức";
            // 
            // txtTrPhong
            // 
            this.txtTrPhong.Location = new System.Drawing.Point(15, 90);
            this.txtTrPhong.Name = "txtTrPhong";
            this.txtTrPhong.Size = new System.Drawing.Size(94, 20);
            this.txtTrPhong.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên PB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(15, 36);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(94, 20);
            this.txtMaPB.TabIndex = 24;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(145, 36);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(112, 20);
            this.txtTenPB.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã PB";
            // 
            // txtNgNhanChuc
            // 
            this.txtNgNhanChuc.Location = new System.Drawing.Point(145, 90);
            this.txtNgNhanChuc.Name = "txtNgNhanChuc";
            this.txtNgNhanChuc.Size = new System.Drawing.Size(112, 20);
            this.txtNgNhanChuc.TabIndex = 29;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 119);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 540);
            this.tabControl1.TabIndex = 42;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPhongBan);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1069, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phòng Bang";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dgvDDPB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1069, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Địa Điểm PB";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnDiscard2);
            this.panel3.Controls.Add(this.btnSave2);
            this.panel3.Controls.Add(this.btnEdit2);
            this.panel3.Controls.Add(this.btnAdd2);
            this.panel3.Controls.Add(this.btnDel2);
            this.panel3.Controls.Add(this.btnReload2);
            this.panel3.Location = new System.Drawing.Point(859, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 513);
            this.panel3.TabIndex = 25;
            // 
            // btnDiscard2
            // 
            this.btnDiscard2.Enabled = false;
            this.btnDiscard2.Location = new System.Drawing.Point(16, 228);
            this.btnDiscard2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiscard2.Name = "btnDiscard2";
            this.btnDiscard2.Size = new System.Drawing.Size(80, 40);
            this.btnDiscard2.TabIndex = 18;
            this.btnDiscard2.Text = "Discard";
            this.btnDiscard2.UseVisualStyleBackColor = true;
            this.btnDiscard2.Click += new System.EventHandler(this.btnDiscard2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Enabled = false;
            this.btnSave2.Location = new System.Drawing.Point(16, 158);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(80, 40);
            this.btnSave2.TabIndex = 17;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnEdit2
            // 
            this.btnEdit2.Location = new System.Drawing.Point(16, 88);
            this.btnEdit2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(80, 40);
            this.btnEdit2.TabIndex = 16;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.UseVisualStyleBackColor = true;
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(16, 15);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(80, 40);
            this.btnAdd2.TabIndex = 15;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnDel2
            // 
            this.btnDel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel2.Location = new System.Drawing.Point(16, 358);
            this.btnDel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(80, 40);
            this.btnDel2.TabIndex = 3;
            this.btnDel2.Text = "Delete";
            this.btnDel2.UseVisualStyleBackColor = true;
            this.btnDel2.Click += new System.EventHandler(this.btnDel2_Click);
            // 
            // btnReload2
            // 
            this.btnReload2.Location = new System.Drawing.Point(16, 293);
            this.btnReload2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload2.Name = "btnReload2";
            this.btnReload2.Size = new System.Drawing.Size(80, 40);
            this.btnReload2.TabIndex = 2;
            this.btnReload2.Text = "Reload";
            this.btnReload2.UseVisualStyleBackColor = true;
            this.btnReload2.Click += new System.EventHandler(this.btnReload2_Click);
            // 
            // dgvDDPB
            // 
            this.dgvDDPB.AllowUserToAddRows = false;
            this.dgvDDPB.AllowUserToDeleteRows = false;
            this.dgvDDPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDDPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB1,
            this.DiaDiem});
            this.dgvDDPB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDDPB.Location = new System.Drawing.Point(3, 3);
            this.dgvDDPB.Name = "dgvDDPB";
            this.dgvDDPB.RowHeadersWidth = 51;
            this.dgvDDPB.Size = new System.Drawing.Size(851, 508);
            this.dgvDDPB.TabIndex = 0;
            this.dgvDDPB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaPB1
            // 
            this.MaPB1.DataPropertyName = "MaPB";
            this.MaPB1.HeaderText = "Mã PB";
            this.MaPB1.MinimumWidth = 6;
            this.MaPB1.Name = "MaPB1";
            this.MaPB1.Width = 125;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.Width = 125;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(538, 115);
            this.splitter1.TabIndex = 44;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBang";
            this.Load += new System.EventHandler(this.FrmPhongBang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDDPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgNhanChuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgNhanChuc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDDPB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDiscard2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnDel2;
        private System.Windows.Forms.Button btnReload2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaDiemPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.Splitter splitter1;
    }
}