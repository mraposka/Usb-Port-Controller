namespace UsbStorageController
{
    partial class UsbStorageController
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enable = new System.Windows.Forms.Button();
            this.disable = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.disableAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.enableCooldown = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableUSBStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAllUSBPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartin5sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // enable
            // 
            this.enable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.enable.Location = new System.Drawing.Point(22, 20);
            this.enable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(138, 39);
            this.enable.TabIndex = 0;
            this.enable.Text = "Enable";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // disable
            // 
            this.disable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.disable.Location = new System.Drawing.Point(281, 20);
            this.disable.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(138, 39);
            this.disable.TabIndex = 1;
            this.disable.Text = "Disable";
            this.disable.UseVisualStyleBackColor = true;
            this.disable.Click += new System.EventHandler(this.Disable_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(190, 4);
            this.exit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(67, 39);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // disableAll
            // 
            this.disableAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.disableAll.Location = new System.Drawing.Point(119, 113);
            this.disableAll.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.disableAll.Name = "disableAll";
            this.disableAll.Size = new System.Drawing.Size(229, 53);
            this.disableAll.TabIndex = 3;
            this.disableAll.Text = "Disable All USB Ports";
            this.disableAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.disableAll.UseVisualStyleBackColor = true;
            this.disableAll.Click += new System.EventHandler(this.DisableAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(229, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Not Recommended";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "If \"Enable\" doesn\'t work, you may restart your computer";
            // 
            // restart
            // 
            this.restart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.restart.Location = new System.Drawing.Point(182, 48);
            this.restart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(87, 39);
            this.restart.TabIndex = 6;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // enableCooldown
            // 
            this.enableCooldown.Interval = 3000;
            this.enableCooldown.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(396, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.restartin5sToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 158);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.HideToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.EnableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableUSBStorageToolStripMenuItem,
            this.disableAllUSBPortsToolStripMenuItem});
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            // 
            // disableUSBStorageToolStripMenuItem
            // 
            this.disableUSBStorageToolStripMenuItem.Name = "disableUSBStorageToolStripMenuItem";
            this.disableUSBStorageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.disableUSBStorageToolStripMenuItem.Text = "Disable USB Storage";
            this.disableUSBStorageToolStripMenuItem.Click += new System.EventHandler(this.DisableUSBStorageToolStripMenuItem_Click);
            // 
            // disableAllUSBPortsToolStripMenuItem
            // 
            this.disableAllUSBPortsToolStripMenuItem.Name = "disableAllUSBPortsToolStripMenuItem";
            this.disableAllUSBPortsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.disableAllUSBPortsToolStripMenuItem.Text = "Disable All USB Ports(!)";
            this.disableAllUSBPortsToolStripMenuItem.Click += new System.EventHandler(this.DisableAllUSBPortsToolStripMenuItem_Click);
            // 
            // restartin5sToolStripMenuItem
            // 
            this.restartin5sToolStripMenuItem.Name = "restartin5sToolStripMenuItem";
            this.restartin5sToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartin5sToolStripMenuItem.Text = "Restart (in 5s)";
            this.restartin5sToolStripMenuItem.Click += new System.EventHandler(this.Restartin5sToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // UsbStorageController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(428, 162);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disableAll);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.disable);
            this.Controls.Add(this.enable);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UsbStorageController";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Storage Controller";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.UsbStorageController_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.Button disable;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button disableAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Timer enableCooldown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableUSBStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableAllUSBPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartin5sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

