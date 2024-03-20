
namespace Optimum
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_Optimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Reload_DWM = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Tray = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerDropper = new System.Windows.Forms.Timer(this.components);
            this.button_AutoDrop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Optimize
            // 
            this.button_Optimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Optimize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Optimize.FlatAppearance.BorderSize = 0;
            this.button_Optimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Optimize.Location = new System.Drawing.Point(5, 118);
            this.button_Optimize.Name = "button_Optimize";
            this.button_Optimize.Size = new System.Drawing.Size(290, 35);
            this.button_Optimize.TabIndex = 4;
            this.button_Optimize.TabStop = false;
            this.button_Optimize.Text = "Optimize";
            this.button_Optimize.UseVisualStyleBackColor = false;
            this.button_Optimize.Click += new System.EventHandler(this.button_Optimize_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.Location = new System.Drawing.Point(265, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 2;
            this.button_Close.TabStop = false;
            this.button_Close.Text = "x";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Location = new System.Drawing.Point(5, 77);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(290, 35);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.TabStop = false;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Reload_DWM
            // 
            this.button_Reload_DWM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Reload_DWM.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Reload_DWM.FlatAppearance.BorderSize = 0;
            this.button_Reload_DWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reload_DWM.Location = new System.Drawing.Point(5, 159);
            this.button_Reload_DWM.Name = "button_Reload_DWM";
            this.button_Reload_DWM.Size = new System.Drawing.Size(290, 35);
            this.button_Reload_DWM.TabIndex = 5;
            this.button_Reload_DWM.TabStop = false;
            this.button_Reload_DWM.Text = "Reload DWM";
            this.button_Reload_DWM.UseVisualStyleBackColor = false;
            this.button_Reload_DWM.Click += new System.EventHandler(this.button_Reload_DWM_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.Location = new System.Drawing.Point(5, 5);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(178, 28);
            this.label_Info.TabIndex = 0;
            this.label_Info.Text = "Optimum x.x.x";
            // 
            // button_Tray
            // 
            this.button_Tray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Tray.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Tray.FlatAppearance.BorderSize = 0;
            this.button_Tray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tray.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Tray.Location = new System.Drawing.Point(229, 5);
            this.button_Tray.Name = "button_Tray";
            this.button_Tray.Size = new System.Drawing.Size(30, 30);
            this.button_Tray.TabIndex = 1;
            this.button_Tray.TabStop = false;
            this.button_Tray.Text = "_";
            this.button_Tray.UseVisualStyleBackColor = false;
            this.button_Tray.Click += new System.EventHandler(this.button_Tray_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "notifyIcon1";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timerDropper
            // 
            this.timerDropper.Interval = 10000;
            this.timerDropper.Tick += new System.EventHandler(this.timerDropper_Tick);
            // 
            // button_AutoDrop
            // 
            this.button_AutoDrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AutoDrop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_AutoDrop.FlatAppearance.BorderSize = 0;
            this.button_AutoDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AutoDrop.Location = new System.Drawing.Point(5, 200);
            this.button_AutoDrop.Name = "button_AutoDrop";
            this.button_AutoDrop.Size = new System.Drawing.Size(290, 35);
            this.button_AutoDrop.TabIndex = 6;
            this.button_AutoDrop.TabStop = false;
            this.button_AutoDrop.Text = "AutoDrop (OFF)";
            this.button_AutoDrop.UseVisualStyleBackColor = false;
            this.button_AutoDrop.Click += new System.EventHandler(this.button_AutoDrop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.button_AutoDrop);
            this.Controls.Add(this.button_Tray);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.button_Reload_DWM);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Optimize);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Optimum";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Optimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Reload_DWM;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_Tray;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Timer timerDropper;
        private System.Windows.Forms.Button button_AutoDrop;
    }
}

