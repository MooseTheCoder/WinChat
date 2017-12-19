namespace WinChat
{
    partial class ChatManager
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
            this.userList = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log = new System.Windows.Forms.RichTextBox();
            this.msgCont = new System.Windows.Forms.GroupBox();
            this.sendMessage = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.AutoScrollCheck = new System.Windows.Forms.CheckBox();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.msgCont.SuspendLayout();
            this.layout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.AllowUserToAddRows = false;
            this.userList.AllowUserToDeleteRows = false;
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username});
            this.userList.Dock = System.Windows.Forms.DockStyle.Left;
            this.userList.Location = new System.Drawing.Point(0, 0);
            this.userList.Name = "userList";
            this.userList.ReadOnly = true;
            this.userList.Size = new System.Drawing.Size(144, 596);
            this.userList.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // log
            // 
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.Location = new System.Drawing.Point(3, 3);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(695, 504);
            this.log.TabIndex = 2;
            this.log.Text = "";
            // 
            // msgCont
            // 
            this.msgCont.Controls.Add(this.layout);
            this.msgCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgCont.Location = new System.Drawing.Point(3, 536);
            this.msgCont.Name = "msgCont";
            this.msgCont.Size = new System.Drawing.Size(695, 57);
            this.msgCont.TabIndex = 3;
            this.msgCont.TabStop = false;
            this.msgCont.Text = "Message Controls";
            // 
            // sendMessage
            // 
            this.sendMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendMessage.Location = new System.Drawing.Point(623, 3);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(63, 32);
            this.sendMessage.TabIndex = 1;
            this.sendMessage.Text = "Send!";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // message
            // 
            this.message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message.Location = new System.Drawing.Point(3, 3);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(614, 32);
            this.message.TabIndex = 0;
            this.message.Text = "";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // AutoScrollCheck
            // 
            this.AutoScrollCheck.AutoSize = true;
            this.AutoScrollCheck.Location = new System.Drawing.Point(3, 513);
            this.AutoScrollCheck.Name = "AutoScrollCheck";
            this.AutoScrollCheck.Size = new System.Drawing.Size(74, 17);
            this.AutoScrollCheck.TabIndex = 2;
            this.AutoScrollCheck.Text = "AutoScroll";
            this.AutoScrollCheck.UseVisualStyleBackColor = true;
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.Controls.Add(this.sendMessage, 1, 0);
            this.layout.Controls.Add(this.message, 0, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(3, 16);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Size = new System.Drawing.Size(689, 38);
            this.layout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.log, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.msgCont, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AutoScrollCheck, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(144, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 596);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ChatManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.userList);
            this.Name = "ChatManager";
            this.Text = "ChatManager";
            this.Load += new System.EventHandler(this.ChatManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.msgCont.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.GroupBox msgCont;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.RichTextBox message;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.CheckBox AutoScrollCheck;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}