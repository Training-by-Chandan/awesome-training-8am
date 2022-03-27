namespace HRManagment.Forms.Admin
{
    partial class UserLeave
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
            this.gridLeaves = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLeaves
            // 
            this.gridLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLeaves.Location = new System.Drawing.Point(42, 92);
            this.gridLeaves.Name = "gridLeaves";
            this.gridLeaves.Size = new System.Drawing.Size(681, 244);
            this.gridLeaves.TabIndex = 0;
            this.gridLeaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLeaves_CellContentClick);
            this.gridLeaves.SelectionChanged += new System.EventHandler(this.gridLeaves_SelectionChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(422, 38);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(157, 21);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(316, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(616, 38);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // UserLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.gridLeaves);
            this.Name = "UserLeave";
            this.Text = "UserLeave";
            this.Load += new System.EventHandler(this.UserLeave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLeaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLeaves;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnConfirm;
    }
}