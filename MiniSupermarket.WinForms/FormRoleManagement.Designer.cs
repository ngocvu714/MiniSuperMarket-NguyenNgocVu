namespace MiniSupermarket.WinForms
{
    partial class FormRoleManagement
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
            txtRoleName = new TextBox();
            lblRoleName = new Label();
            txtId = new TextBox();
            lblId = new Label();
            dgvRoles = new DataGridView();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();

            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnLoad);
            grpInput.Controls.Add(btnDelete);
            grpInput.Controls.Add(btnUpdate);
            grpInput.Controls.Add(btnAdd);
            grpInput.Controls.Add(txtDescription);
            grpInput.Controls.Add(lblDescription);
            grpInput.Controls.Add(txtRoleName);
            grpInput.Controls.Add(lblRoleName);
            grpInput.Controls.Add(txtId);
            grpInput.Controls.Add(lblId);
            grpInput.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(350, 476);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = " Thông tin vai trò ";

            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 17);
            lblId.Text = "Mã vai trò:";

            // 
            // txtId
            // 
            txtId.Location = new Point(20, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(310, 25);
            txtId.BackColor = Color.WhiteSmoke;

            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new Point(20, 110);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(91, 17);
            lblRoleName.Text = "Tên vai trò:";

            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(20, 135);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(310, 25);

            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(51, 17);
            lblDescription.Text = "Mô tả:";

            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 205);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(310, 100);

            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(20, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 35);
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(185, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 35);
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(20, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 35);
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(149, 165, 166);
            btnLoad.ForeColor = Color.White;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Location = new Point(185, 380);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(145, 35);
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;

            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = Color.White;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(380, 12);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new Size(540, 476);
            dgvRoles.TabIndex = 2;
            dgvRoles.CellClick += dgvRoles_CellClick;

            // 
            // FormRoleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 501);
            Controls.Add(dgvRoles);
            Controls.Add(grpInput);
            Name = "FormRoleManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Vai trò";
            Load += FormRoleManagement_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtRoleName;
        private Label lblRoleName;
        private TextBox txtId;
        private Label lblId;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvRoles;
    }
}