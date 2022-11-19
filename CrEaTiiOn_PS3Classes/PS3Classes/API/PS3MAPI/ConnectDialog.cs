using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PS3ManagerAPI
{
    /// <summary>
    /// Dumped from PS3ManagerAPI.dll using dnSpy, Original Author is: _NzV_
    /// </summary>
    public class ConnectDialog : Form
    {
        // Token: 0x0600000B RID: 11 RVA: 0x00002750 File Offset: 0x00000950
        public ConnectDialog()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600000C RID: 12 RVA: 0x0000275E File Offset: 0x0000095E
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600000D RID: 13 RVA: 0x00002780 File Offset: 0x00000980
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP: ";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(44, 23);
            this.txtIp.MaxLength = 16;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(116, 20);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(66, 58);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 21);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Connect";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(151, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(222, 23);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(55, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "7887";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PORT: ";
            // 
            // ConnectDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(292, 85);
            this.ControlBox = false;
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection with PS3 Manager API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x0400000C RID: 12
        private IContainer components;

        // Token: 0x0400000D RID: 13
        private Label label1;

        // Token: 0x0400000E RID: 14
        private Button btnOK;

        // Token: 0x0400000F RID: 15
        private Button btnCancel;

        // Token: 0x04000010 RID: 16
        protected internal TextBox txtIp;

        // Token: 0x04000011 RID: 17
        protected internal TextBox txtPort;

        // Token: 0x04000012 RID: 18
        private Label label2;
    }
}
