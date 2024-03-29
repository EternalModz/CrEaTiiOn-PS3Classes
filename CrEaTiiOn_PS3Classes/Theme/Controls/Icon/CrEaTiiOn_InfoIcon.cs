﻿#region Imports

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

#endregion

namespace CBH.Controls
{
    #region CrEaTiiOn_InfoIcon

    public class CrEaTiiOn_InfoIcon : Control
    {
        #region Settings

        private Color _BaseColor = Color.FromArgb(246, 246, 246);
        public Color BaseColor
        {
            get => _BaseColor;
            set => _BaseColor = value;
        }

        private Color _CircleColor = Color.Gray;
        public Color CircleColor
        {
            get => _CircleColor;
            set => _CircleColor = value;
        }

        private string _String = "¡";
        public string String
        {
            get => _String;
            set => _String = value;
        }

        #endregion

        public CrEaTiiOn_InfoIcon()
        {
            ForeColor = Color.DimGray;
            BackColor = Color.FromArgb(20, 20, 20);
            ForeColor = Color.White;
            Font = new("Segoe UI", 25, FontStyle.Bold);
            Size = new(33, 33);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            e.Graphics.FillEllipse(new SolidBrush(_CircleColor), new Rectangle(1, 1, 29, 29));
            e.Graphics.FillEllipse(new SolidBrush(_BaseColor), new Rectangle(3, 3, 25, 25));

            e.Graphics.DrawString(_String, Font, new SolidBrush(ForeColor), new Rectangle(4, -14, Width, 43), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });
        }
    }

    #endregion
}