namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
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
            grpInput = new GroupBox();
            btnLoad = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            txtId = new TextBox();
            lblId = new Label();
            grpSearch = new GroupBox();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            dgvCategories = new DataGridView();
            grpInput.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnDelete);
            grpInput.Controls.Add(btnUpdate);
            grpInput.Controls.Add(btnAdd);
            grpInput.Controls.Add(txtDescription);
            grpInput.Controls.Add(lblDescription);
            grpInput.Controls.Add(txtCategoryName);
            grpInput.Controls.Add(lblCategoryName);
            grpInput.Controls.Add(txtId);
            grpInput.Controls.Add(lblId);
            grpInput.Font = new Font("Segoe UI", 9.5F);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(350, 476);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = " Thông tin nhóm hàng ";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(149, 165, 166);
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(414, 26);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(95, 28);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(38, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(268, 35);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(185, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 205);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(310, 100);
            txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(46, 17);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Mô tả:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(20, 135);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(310, 24);
            txtCategoryName.TabIndex = 6;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(20, 110);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(101, 17);
            lblCategoryName.TabIndex = 7;
            lblCategoryName.Text = "Tên nhóm hàng:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Location = new Point(20, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(310, 24);
            txtId.TabIndex = 8;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(55, 17);
            lblId.TabIndex = 9;
            lblId.Text = "Mã loại:";
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(btnLoad);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(txtKeyword);
            grpSearch.Font = new Font("Segoe UI", 9.5F);
            grpSearch.Location = new Point(380, 12);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(540, 70);
            grpSearch.TabIndex = 1;
            grpSearch.TabStop = false;
            grpSearch.Text = " Tìm kiếm ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 73, 94);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(313, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 28);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(20, 30);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Nhập tên nhóm hàng cần tìm...";
            txtKeyword.Size = new Size(275, 24);
            txtKeyword.TabIndex = 1;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(380, 95);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(540, 393);
            dgvCategories.TabIndex = 2;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // FormCategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 501);
            Controls.Add(dgvCategories);
            Controls.Add(grpSearch);
            Controls.Add(grpInput);
            Name = "FormCategoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Danh mục hàng hóa";
            Load += FormCategoryManagement_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private TextBox txtId;
        private Label lblId;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grpSearch;
        private Button btnSearch;
        private TextBox txtKeyword;
        private DataGridView dgvCategories;
    }
}