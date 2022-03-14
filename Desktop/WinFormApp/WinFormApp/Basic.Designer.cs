namespace WinFormApp
{
    partial class Basic
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gridStudent = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFnamevalid = new System.Windows.Forms.Label();
            this.lblLnameValid = new System.Windows.Forms.Label();
            this.lblEmailValid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(41, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(41, 103);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(86, 20);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(41, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.White;
            this.txtFName.Location = new System.Drawing.Point(184, 56);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(338, 26);
            this.txtFName.TabIndex = 3;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(184, 100);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(338, 26);
            this.txtLName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(184, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(261, 228);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 48);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(412, 228);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 48);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gridStudent
            // 
            this.gridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudent.Location = new System.Drawing.Point(45, 347);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.Size = new System.Drawing.Size(477, 227);
            this.gridStudent.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(60, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 9;
            this.lblId.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(412, 228);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 48);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 48);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // lblFnamevalid
            // 
            this.lblFnamevalid.AutoSize = true;
            this.lblFnamevalid.ForeColor = System.Drawing.Color.Red;
            this.lblFnamevalid.Location = new System.Drawing.Point(525, 59);
            this.lblFnamevalid.Name = "lblFnamevalid";
            this.lblFnamevalid.Size = new System.Drawing.Size(15, 20);
            this.lblFnamevalid.TabIndex = 12;
            this.lblFnamevalid.Text = "*";
            // 
            // lblLnameValid
            // 
            this.lblLnameValid.AutoSize = true;
            this.lblLnameValid.ForeColor = System.Drawing.Color.Red;
            this.lblLnameValid.Location = new System.Drawing.Point(525, 103);
            this.lblLnameValid.Name = "lblLnameValid";
            this.lblLnameValid.Size = new System.Drawing.Size(15, 20);
            this.lblLnameValid.TabIndex = 13;
            this.lblLnameValid.Text = "*";
            // 
            // lblEmailValid
            // 
            this.lblEmailValid.AutoSize = true;
            this.lblEmailValid.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValid.Location = new System.Drawing.Point(525, 154);
            this.lblEmailValid.Name = "lblEmailValid";
            this.lblEmailValid.Size = new System.Drawing.Size(15, 20);
            this.lblEmailValid.TabIndex = 14;
            this.lblEmailValid.Text = "*";
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 608);
            this.Controls.Add(this.lblEmailValid);
            this.Controls.Add(this.lblLnameValid);
            this.Controls.Add(this.lblFnamevalid);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.gridStudent);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Basic";
            this.Text = "Basic";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView gridStudent;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFnamevalid;
        private System.Windows.Forms.Label lblLnameValid;
        private System.Windows.Forms.Label lblEmailValid;
    }
}