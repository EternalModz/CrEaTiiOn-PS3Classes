﻿#region Imports

using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using SysAction = System.Action;

#endregion

namespace CBH.Controls
{
    #region CrEaTiiOn_ExtendedFileSystemWatcher

    public class CrEaTiiOn_ExtendedFileSystemWatcher : Component
    {
        public CrEaTiiOn_ExtendedFileSystemWatcher()
        {
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Attributes | NotifyFilters.Size | NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.CreationTime | NotifyFilters.Security;
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.Created += OnCreated;
            watcher.Changed += OnChanged;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.EnableRaisingEvents = false;
            watcher.InternalBufferSize = 131072;
        }

        public event EventHandler ServiceStarted;

        protected virtual void OnServiceStarted()
        {
            ServiceStarted?.Invoke(this, null);
        }

        public event EventHandler ServiceStopped;

        protected virtual void OnServiceStopped(FileSystemEventArgs e)
        {
            ServiceStopped?.Invoke(this, null);
        }

        public event FileSystemEventHandler FileCreated;

        protected virtual void OnFileCreated(FileSystemEventArgs e)
        {
            FileCreated?.Invoke(this, e);
        }

        public event FileSystemEventHandler FileDeleted;

        protected virtual void OnFileDeleted(FileSystemEventArgs e)
        {
            FileDeleted?.Invoke(this, e);
        }

        public event FileSystemEventHandler FileChanged;

        protected virtual void OnFileChanged(FileSystemEventArgs e)
        {
            FileChanged?.Invoke(this, e);
        }

        public event RenamedEventHandler FileRenamed;

        protected virtual void OnFileRenamed(RenamedEventArgs e)
        {
            FileRenamed?.Invoke(this, e);
        }

        [Category("CrEaTiiOn")]
        [Browsable(true)]
        [Description("Choose when the watcher updates")]
        public NotifyFilters UpdateOn
        {
            get => watcher.NotifyFilter;
            set => watcher.NotifyFilter = value;
        }

        [Category("CrEaTiiOn")]
        [Browsable(true)]
        [Description("Watch subdirectories")]
        public bool WatchSubdirectories
        {
            get => watcher.IncludeSubdirectories;
            set => watcher.IncludeSubdirectories = value;
        }

        [Category("CrEaTiiOn")]
        [Browsable(true)]
        [Description("The path to watch")]
        public string WatchPath
        {
            get => watcher.Path;
            set
            {
                if (Directory.Exists(value))
                {
                    watcher.Path = value;
                    return;
                }
                if (File.Exists(value))
                {
                    watcher.Path = Path.GetDirectoryName(value);
                    watcher.Filter = Path.GetFileName(value);
                }
            }
        }

        [Category("CrEaTiiOn")]
        [Browsable(true)]
        [Description("Filter for certin files")]
        public string Filters
        {
            get => watcher.Filter;
            set => watcher.Filter = value;
        }

        [Category("CrEaTiiOn")]
        [Browsable(true)]
        [Description("The control to output to(via Text)")]
        public Control OutputControl
        {
            get => outputControl;
            set => outputControl = value;
        }

        [Category("CrEaTiiOn")]
        [Browsable(true)]
        [Description("Remove WatchPath from output")]
        public bool SlimOutput
        {
            get => slimOutput;
            set => slimOutput = value;
        }

        public void StartService()
        {
            ServiceStarted(this, null);
            if (!watcher.EnableRaisingEvents)
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        public void StopService()
        {
            ServiceStopped(this, null);
            if (watcher.EnableRaisingEvents)
            {
                watcher.EnableRaisingEvents = false;
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            if (lastWriteTime != lastRead && File.Exists(e.FullPath))
            {
                lastRead = lastWriteTime;
                if (slimOutput)
                {
                    outputControl.Invoke(new SysAction(delegate ()
                    {
                        outputControl.Text = outputControl.Text + "\nChanged: " + e.FullPath.Replace(watcher.Path, "");
                    }));
                }
                else
                {
                    outputControl.Invoke(new SysAction(delegate ()
                    {
                        outputControl.Text = outputControl.Text + "\nChanged: " + e.FullPath;
                    }));
                }
                OnFileChanged(e);
            }
        }

        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            lastRead = lastWriteTime;
            if (slimOutput)
            {
                if (outputControl.InvokeRequired)
                {
                    outputControl.Invoke(new SysAction(delegate ()
                    {
                        outputControl.Text = outputControl.Text + "\nDeleted: " + e.FullPath.Replace(watcher.Path, "");
                    }));
                }
            }
            else if (outputControl.InvokeRequired)
            {
                outputControl.Invoke(new SysAction(delegate ()
                {
                    outputControl.Text = outputControl.Text + "\nDeleted: " + e.FullPath;
                }));
            }
            OnFileDeleted(e);
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            if (lastWriteTime != lastRead)
            {
                lastRead = lastWriteTime;
                if (slimOutput)
                {
                    if (outputControl.InvokeRequired)
                    {
                        outputControl.Invoke(new SysAction(delegate ()
                        {
                            outputControl.Text = outputControl.Text + "\nCreated: " + e.FullPath.Replace(watcher.Path, "");
                        }));
                    }
                }
                else if (outputControl.InvokeRequired)
                {
                    outputControl.Invoke(new SysAction(delegate ()
                    {
                        outputControl.Text = outputControl.Text + "\nCreated: " + e.FullPath;
                    }));
                }
                OnFileCreated(e);
            }
        }

        public void OnRenamed(object source, RenamedEventArgs e)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
            if (lastWriteTime != lastRead)
            {
                lastRead = lastWriteTime;
                if (slimOutput)
                {
                    if (outputControl.InvokeRequired)
                    {
                        outputControl.Invoke(new SysAction(delegate ()
                        {
                            outputControl.Text = outputControl.Text + "\nRenamed: " + e.FullPath.Replace(watcher.Path, "");
                        }));
                    }
                }
                else if (outputControl.InvokeRequired)
                {
                    outputControl.Invoke(new SysAction(delegate ()
                    {
                        outputControl.Text = outputControl.Text + "\nRenamed: " + e.FullPath;
                    }));
                }
                OnFileRenamed(e);
            }
        }

        private readonly FileSystemWatcher watcher = new();

        private DateTime lastRead = DateTime.MinValue;

        private Control outputControl;

        private bool slimOutput = true;
    }

    #endregion
}