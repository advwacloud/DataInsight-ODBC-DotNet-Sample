namespace HiveConnector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDSN = new System.Windows.Forms.TextBox();
            this.lblDSN = new System.Windows.Forms.Label();
            this.dgvODBC = new System.Windows.Forms.DataGridView();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.lblSQL = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODBC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(627, 29);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(129, 37);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDSN
            // 
            this.txtDSN.Location = new System.Drawing.Point(130, 32);
            this.txtDSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtDSN.Name = "txtDSN";
            this.txtDSN.Size = new System.Drawing.Size(478, 29);
            this.txtDSN.TabIndex = 1;
            this.txtDSN.Text = "dis-sa";
            // 
            // lblDSN
            // 
            this.lblDSN.AutoSize = true;
            this.lblDSN.Location = new System.Drawing.Point(59, 35);
            this.lblDSN.Name = "lblDSN";
            this.lblDSN.Size = new System.Drawing.Size(43, 20);
            this.lblDSN.TabIndex = 3;
            this.lblDSN.Text = "DSN";
            // 
            // dgvODBC
            // 
            this.dgvODBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvODBC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvODBC.Location = new System.Drawing.Point(0, 238);
            this.dgvODBC.Name = "dgvODBC";
            this.dgvODBC.RowHeadersWidth = 51;
            this.dgvODBC.RowTemplate.Height = 29;
            this.dgvODBC.Size = new System.Drawing.Size(788, 354);
            this.dgvODBC.TabIndex = 5;
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(130, 95);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(478, 113);
            this.txtSQL.TabIndex = 6;
            this.txtSQL.Text = "SELECT * FROM `main.d1`;";
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Location = new System.Drawing.Point(64, 98);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(39, 20);
            this.lblSQL.TabIndex = 7;
            this.lblSQL.Text = "SQL";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(627, 95);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(129, 36);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.LightGray;
            this.lblStatus.Location = new System.Drawing.Point(28, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 15);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 592);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDSN);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblDSN);
            this.Controls.Add(this.dgvODBC);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblSQL);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvODBC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnect;
        private TextBox txtDSN;
        private Label lblDSN;
        private DataGridView dgvODBC;
        private TextBox txtSQL;
        private Label lblSQL;
        private Button btnExecute;
        private Label lblStatus;
    }
}