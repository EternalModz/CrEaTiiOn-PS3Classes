﻿#region Imports

using System;
using System.ComponentModel;
using System.Windows.Forms;

#endregion

namespace CBH.Controls
{
    #region CrEaTiiOn_Sleeper

    public class CrEaTiiOn_Sleeper : Component
    {
        public void Sleep(int Milliseconds)
        {
            DateTime Time = DateTime.Now.AddMilliseconds(Milliseconds);

            while (DateTime.Now < Time)
            {
                Application.DoEvents();
            }
        }
    }

    #endregion
}