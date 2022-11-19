﻿using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PS3Lib
{
    public partial class ConsoleList
    {
		#region Icon Byte Array (Opening this may lag your visual studio)
        /// <summary>
        /// Ps3 icon as byte[]
        /// </summary>
        private byte[] ps3icon = new byte[]
        {
        };
		
		/// <summary>
        /// The icon is stored as byte[] for ease of use from project to project
        /// This is a helper method for that.
        /// </summary>
        private static Icon BytesToIcon(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Icon(ms);
            }
        }
		#endregion

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
		
		private Label lblInfo;
        private ListViewGroup listViewGroup;
        private ListView listView;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Consoles", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleList));
            this.lblInfo = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.btnRefresh = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.btnConnect = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.crEaTiiOn_Ultimate_GradientButton1 = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(69, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(176, 15);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Select a console within this grid.";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.Color.White;
            listViewGroup1.Header = "Consoles";
            listViewGroup1.Name = "consoleGroup";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 45);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(290, 215);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.BorderSize = 1;
            this.btnRefresh.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnRefresh.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnRefresh.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(160, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(142, 40);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.crEaTiiOn_Ultimate_GradientButton5_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnConnect.BorderRadius = 10;
            this.btnConnect.BorderSize = 1;
            this.btnConnect.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnConnect.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnConnect.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.Location = new System.Drawing.Point(12, 270);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(142, 40);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.TextColor = System.Drawing.Color.White;
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.crEaTiiOn_Ultimate_GradientButton4_Click);
            // 
            // crEaTiiOn_Ultimate_GradientButton1
            // 
            this.crEaTiiOn_Ultimate_GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.crEaTiiOn_Ultimate_GradientButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.crEaTiiOn_Ultimate_GradientButton1.BorderRadius = 10;
            this.crEaTiiOn_Ultimate_GradientButton1.BorderSize = 1;
            this.crEaTiiOn_Ultimate_GradientButton1.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.crEaTiiOn_Ultimate_GradientButton1.FlatAppearance.BorderSize = 0;
            this.crEaTiiOn_Ultimate_GradientButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.crEaTiiOn_Ultimate_GradientButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.crEaTiiOn_Ultimate_GradientButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crEaTiiOn_Ultimate_GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.crEaTiiOn_Ultimate_GradientButton1.ForeColor = System.Drawing.Color.White;
            this.crEaTiiOn_Ultimate_GradientButton1.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crEaTiiOn_Ultimate_GradientButton1.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crEaTiiOn_Ultimate_GradientButton1.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.crEaTiiOn_Ultimate_GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("crEaTiiOn_Ultimate_GradientButton1.Image")));
            this.crEaTiiOn_Ultimate_GradientButton1.Location = new System.Drawing.Point(12, 315);
            this.crEaTiiOn_Ultimate_GradientButton1.Name = "crEaTiiOn_Ultimate_GradientButton1";
            this.crEaTiiOn_Ultimate_GradientButton1.Size = new System.Drawing.Size(290, 40);
            this.crEaTiiOn_Ultimate_GradientButton1.TabIndex = 6;
            this.crEaTiiOn_Ultimate_GradientButton1.Text = "Cancel";
            this.crEaTiiOn_Ultimate_GradientButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crEaTiiOn_Ultimate_GradientButton1.TextColor = System.Drawing.Color.White;
            this.crEaTiiOn_Ultimate_GradientButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.crEaTiiOn_Ultimate_GradientButton1.UseVisualStyleBackColor = false;
            this.crEaTiiOn_Ultimate_GradientButton1.Click += new System.EventHandler(this.crEaTiiOn_Ultimate_GradientButton1_Click);
            // 
            // ConsoleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(314, 367);
            this.Controls.Add(this.crEaTiiOn_Ultimate_GradientButton1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.listView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a console...";
            this.Load += new System.EventHandler(this.ConsoleList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton btnRefresh;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton btnConnect;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton crEaTiiOn_Ultimate_GradientButton1;
    }
}