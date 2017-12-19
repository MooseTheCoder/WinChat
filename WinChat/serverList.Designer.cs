namespace WinChat
{
    partial class serverList
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
            this.serverListGrid = new System.Windows.Forms.DataGridView();
            this.servername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverMOTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serverListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // serverListGrid
            // 
            this.serverListGrid.AllowUserToAddRows = false;
            this.serverListGrid.AllowUserToDeleteRows = false;
            this.serverListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servername,
            this.serverHost,
            this.serverMOTD,
            this.owner});
            this.serverListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverListGrid.Location = new System.Drawing.Point(0, 0);
            this.serverListGrid.Name = "serverListGrid";
            this.serverListGrid.ReadOnly = true;
            this.serverListGrid.Size = new System.Drawing.Size(594, 261);
            this.serverListGrid.TabIndex = 0;
            // 
            // servername
            // 
            this.servername.HeaderText = "Server Name";
            this.servername.Name = "servername";
            this.servername.ReadOnly = true;
            // 
            // serverHost
            // 
            this.serverHost.HeaderText = "Address";
            this.serverHost.Name = "serverHost";
            this.serverHost.ReadOnly = true;
            // 
            // serverMOTD
            // 
            this.serverMOTD.HeaderText = "MOTD";
            this.serverMOTD.Name = "serverMOTD";
            this.serverMOTD.ReadOnly = true;
            // 
            // owner
            // 
            this.owner.HeaderText = "Owner";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            // 
            // serverList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.serverListGrid);
            this.Name = "serverList";
            this.Text = "Server List";
            this.Load += new System.EventHandler(this.serverList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView serverListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn servername;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverMOTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
    }
}