using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PS3ManagerAPI
{
    /// <summary>
    /// Dumped from PS3ManagerAPI.dll using dnSpy, Original Author is: _NzV_
    /// </summary>
    public class LogDialog : Form
    {
        // Token: 0x06000005 RID: 5 RVA: 0x00002450 File Offset: 0x00000650
        public LogDialog()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000006 RID: 6 RVA: 0x0000245E File Offset: 0x0000065E
        public LogDialog(PS3MAPI MyPS3MAPI) : this()
        {
            this.PS3MAPI = MyPS3MAPI;
        }

        // Token: 0x06000007 RID: 7 RVA: 0x0000246D File Offset: 0x0000066D
        private void LogDialog_Refresh(object sender, EventArgs e)
        {
            if (this.PS3MAPI != null)
            {
                this.tB_Log.Text = this.PS3MAPI.Log;
            }
        }

        // Token: 0x06000008 RID: 8 RVA: 0x0000248D File Offset: 0x0000068D
        private void button1_Click(object sender, EventArgs e)
        {
            base.Hide();
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002495 File Offset: 0x00000695
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600000A RID: 10 RVA: 0x000024B4 File Offset: 0x000006B4
        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LogDialog));
            this.tB_Log = new TextBox();
            this.btnRefresh = new Button();
            this.button1 = new Button();
            base.SuspendLayout();
            this.tB_Log.BackColor = Color.White;
            this.tB_Log.Location = new Point(12, 12);
            this.tB_Log.MaxLength = 16;
            this.tB_Log.Multiline = true;
            this.tB_Log.Name = "tB_Log";
            this.tB_Log.ReadOnly = true;
            this.tB_Log.ScrollBars = ScrollBars.Both;
            this.tB_Log.Size = new Size(429, 327);
            this.tB_Log.TabIndex = 10;
            this.btnRefresh.Location = new Point(290, 345);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(71, 21);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += this.LogDialog_Refresh;
            this.button1.Location = new Point(370, 345);
            this.button1.Name = "button1";
            this.button1.Size = new Size(71, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(453, 378);
            base.ControlBox = false;
            base.Controls.Add(this.button1);
            base.Controls.Add(this.btnRefresh);
            base.Controls.Add(this.tB_Log);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            //base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "LogDialog";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "PS3 Manager API Log";
            base.Activated += this.LogDialog_Refresh;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x04000007 RID: 7
        private PS3MAPI PS3MAPI;

        // Token: 0x04000008 RID: 8
        private IContainer components;

        // Token: 0x04000009 RID: 9
        protected internal TextBox tB_Log;

        // Token: 0x0400000A RID: 10
        private Button btnRefresh;

        // Token: 0x0400000B RID: 11
        private Button button1;
    }
}
