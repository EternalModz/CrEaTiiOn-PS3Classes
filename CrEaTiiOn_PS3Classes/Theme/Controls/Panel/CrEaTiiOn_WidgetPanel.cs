﻿#region Imports

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace CBH.Controls
{
    #region CrEaTiiOn_WidgetPanel

    public class CrEaTiiOn_WidgetPanel : System.Windows.Forms.Panel
    {
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            if (!ControlsAsWidgets)
            {
                foreach (object obj in base.Controls)
                {
                    Control control = (Control)obj;
                    control.MouseDown += WidgetDown;
                    control.MouseUp += WidgetUp;
                    control.MouseMove += WidgetMove;
                }
            }
        }

        [Category("CrEaTiiOn")]
        [Browsable(true)]
        [Description("Reat controls as widgets")]
        public bool ControlsAsWidgets
        {
            get => controlsAsWidgets;
            set => controlsAsWidgets = value;
        }

        private void WidgetDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void WidgetUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void WidgetMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                ((Control)sender).Location = new Point(e.X, e.Y);
            }
        }

        private bool controlsAsWidgets;

        private bool isDragging;
    }

    #endregion
}