// Assembly         : MVCDemoRibbon.Controllers.Child
// Author           : jian.wang
// Created          : 2016-11-30
//
// Last Modified By : jian.wang
// Last Modified On : 2016-11-30
// <copyright file="classNmae.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary>
//     declaration of the class 
// </summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.Control.User;
using MVCDemoRibbon.Broker.View.User;
using Jonas.Common;
using MVCDemoRibbon.Model.Extra;

namespace MVCDemoRibbon.Controller.User
{
    class ProgramCommController : ACtrlController, IProgramCommController
    {
        #region  Method

        [DllImport("User32", CharSet = CharSet.Auto)]
        // API call to get the current window layout
        private static extern int GetWindowLong(IntPtr hWnd, int Index);
        [DllImport("User32", CharSet = CharSet.Auto)]
        // API call to set the window layout
        private static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);
        [DllImport("User32", CharSet = CharSet.Auto)]
        // API call to make the window transpairent
        private static extern int SetLayeredWindowAttributes(IntPtr hWnd, int clrKey, Byte bAlpha, int dwFlags);

        [DllImport("user32.dll", EntryPoint = "GetTaskmanWindow", SetLastError = true)]
        public static extern IntPtr GetTaskmanWindow();

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr pWnd, IntPtr childWnd, string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll", EntryPoint = "GetWindowText", SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder st, int cnt);

        [DllImport("user32.dll", EntryPoint = "GetClassName", SetLastError = true)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder st, int cnt);

        [DllImport("user32.dll", EntryPoint = "SendMessage", SetLastError = true)]
        private static extern int SendMessage(IntPtr HWnd, uint Msg, int WParam, int LParam);

        [DllImport("user32.dll", EntryPoint = "PostMessage", SetLastError = true)]
        private static extern int PostMessage(IntPtr HWnd, uint Msg, int WParam, int LParam);

        [DllImport("user32.dll", EntryPoint = "EnumChildWindows", SetLastError = true)]
        private static extern bool EnumChildWindows(IntPtr hWndParent, CallBack lpEnumFunc, int lParam);

        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MINIMIZE = 0xF020;
        private const int SC_MAXIMIZE = 0xF030;
        private const long WS_EX_TOOLWINDOW = 0x00000080L;
        private const long WS_EX_APPWINDOW = 0x00040000L;

        private const int LWA_COLORKEY = 1;
        private const int LWA_ALPHA = 2;
        private const int GWL_STYLE = -16;
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x00080000;

        public delegate bool CallBack(IntPtr hwnd, int lParam);

        public ProgramCommController(IMdiRibbonController mdiNavigateController, Logger logger, UserEventArgs userEventArgs)
            : base(mdiNavigateController, logger, userEventArgs)
        {
            this.ViewName = "ProgramCommView";
            Initialize();
        }

        /// <summary>
        /// Initialize the view to be shown
        /// </summary>
        private void Initialize()
        {
            System.Windows.Forms.Cursor currentCursor = System.Windows.Forms.Cursor.Current;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                this.m_view = base.CreateView() as IProgramCommView;
                this.m_view.BtnSelectPath.Click += BtnSelectPath_Click;
                this.m_view.BtnStartProgram.Click += BtnStartProgram_Click;
                this.m_view.BtnReadFileData.Click += BtnReadFileData_Click;
                this.m_view.BtnWriteFileData.Click += BtnWriteFileData_Click;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                System.Windows.Forms.Cursor.Current = currentCursor;
            }

        }

        bool EnumChildProc(IntPtr hWnd, int lParam)
        {
	        //[注意]得到的窗口类名肯定不为空,但窗口标题可能为空
            int maxPath = 256;
            StringBuilder st = new StringBuilder(maxPath);
            GetClassName(hWnd, st, maxPath);      
	        GetWindowText(hWnd, st, maxPath);

	        //OutputDebugString(szClassName);
	        //OutputDebugString("\r\n");

	        //例如:得到类名结果如下：
	        //说明:获取任务栏上系统窗口很全面,但获取其他用户应用程序窗口不全面
	        // TrayNotifyWnd
	        // Button								//"开始按钮"的窗口类名称
	        // MSTaskListWClass						//显示"任务栏图标"的窗口类名称
	        // CiceroUIWndFrame						//右边的显示"输入法"窗口类名称
	        // ToolbarWindow32						//右边的显示"托盘图标"窗口类名称
	        // TrayClockWClass						//右边显示"日期时间"的窗口类名称
	        // TrayShowDesktopButtonWClass			//最右边的"显示桌面"的窗口类名称
	        // Edit									//任务栏中的"地址栏"窗口类名称
	        // ... ...
	        // SysPager								//任务栏上其他应用程序窗口类名称
	        // ReBarWindow32
	        // MSTaskSwWClass
	        // Address Band Root
	        // msctls_progress32
	        // ComboBoxEx32

	        return true;
        }

        void BtnStartProgram_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = null;
                if (File.Exists(this._exeFullPath))
                {
                    proc = new Process();
                    proc.StartInfo.FileName = this._exeFullPath; //运行程序界面
                    proc.Start();

                    //PostMessage(proc.MainWindowHandle, WM_SYSCOMMAND, SC_MINIMIZE, 0);
                }

                //IntPtr hwnd = FindWindow("Shell_TrayWnd", null);
                //IntPtr childWnd = FindWindowEx(hwnd, IntPtr.Zero, "ReBarWindow32", null);
                //IntPtr grandChildWnd = FindWindowEx(childWnd, IntPtr.Zero, "MSTaskSwWClass", null);
                //IntPtr ggChildWnd = FindWindowEx(grandChildWnd, IntPtr.Zero, "MSTaskListWClass", null);

                //IntPtr taskWnd = GetTaskmanWindow();//任务栏窗口句柄
                //IntPtr ggChildWnd = FindWindowEx(taskWnd, IntPtr.Zero, "MSTaskListWClass", null);

                //bool ret = EnumChildWindows(hwnd, EnumChildProc, 0);

                //ShowWindow(ggChildWnd, 1);

                //long dwExStyle = (long)GetWindowLong(hwnd, GWL_EXSTYLE);//GWL_EXSTYLE= (-20) 扩展窗口样式 
                //dwExStyle |= WS_EX_TOOLWINDOW;
                //dwExStyle = dwExStyle & ~WS_EX_APPWINDOW;
                //SetWindowLong(hwnd, GWL_EXSTYLE, (int)dwExStyle);

                if (null != proc)
                {
                    //long dwExStyle = (long)GetWindowLong(proc.MainWindowHandle, GWL_EXSTYLE);
                    //dwExStyle = dwExStyle & (~WS_EX_APPWINDOW);
                    //dwExStyle |= WS_EX_TOOLWINDOW;
                    //int temp = (int)dwExStyle;
                    //SetWindowLong(proc.MainWindowHandle, GWL_EXSTYLE, (int)dwExStyle);

                    //long ExtendedStyle = GetWindowLong (proc.MainWindowHandle, GWL_EXSTYLE);
                    //SetWindowLong(proc.MainWindowHandle, GWL_EXSTYLE, (int)(ExtendedStyle | WS_EX_TOOLWINDOW & (~WS_EX_APPWINDOW)));


                    //SetWindowLong(proc.MainWindowHandle, GWL_EXSTYLE, GetWindowLong(proc.MainWindowHandle, GWL_EXSTYLE) | WS_EX_LAYERED);
                    //SetLayeredWindowAttributes(proc.MainWindowHandle, 0, 0, LWA_ALPHA|LWA_COLORKEY); 
                }
            }
            catch (Exception ex)
            {
                string st = ex.Message;   
            }
            
        }


        void BtnSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.RestoreDirectory = true;
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                this._exeFullPath = dialog.FileName;
                this.m_view.TxtExePath.Text = dialog.SafeFileName;
            }
        }

        void BtnWriteFileData_Click(object sender, EventArgs e)
        {
            try
            {
                string mapName = "_Text";
                if (null == _memoryModule)
                {
                    _memoryModule = new MemoryModule<byte>(mapName, 1024);
                }

                if (string.Empty.Equals(this.m_view.TxtWrite.Text))
                {
                    return;
                }

                byte[] byteArray = System.Text.Encoding.Default.GetBytes(this.m_view.TxtWrite.Text);
                _memoryModule.SetPosition(0, byteArray);
            }
            catch (Exception)
            {
                throw;
            }
        }

        void BtnReadFileData_Click(object sender, EventArgs e)
        {
            try
            {
                string mapName = "_Text";
                if (null == _memoryModule)
                {
                    _memoryModule = new MemoryModule<byte>(mapName, 1024);
                }

                byte[] data = _memoryModule.GetAll();
                this.m_view.TxtRead.Text = System.Text.Encoding.Default.GetString(data).Trim();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion  Method

        #region  Property   属性
        IProgramCommView IProgramCommController.ProgramCommView
        {
            get { return this.m_view; }
        }
        #endregion  Property


        #region  Filed

        /// <summary>
        /// the view
        /// </summary>
        private IProgramCommView m_view;
        private string _exeFullPath;
        private MemoryModule<byte> _memoryModule = null;
        #endregion  Filed
    }
}
