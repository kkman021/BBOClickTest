using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Gma.UserActivityMonitor;

/*
 * Gma.UserActivityMonitor Create By George Mamaladze.
 *      http://www.codeproject.com/Articles/7294/Processing-Global-Mouse-and-Keyboard-Hooks-in-C
 */

namespace BBOClick
{
    public partial class Form1 : Form
    {
        #region 變數設定
        int counter = 0;
        static bool IsStart = false;

        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr ext);
        [DllImportAttribute("User32.DLL")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        enum DisplayType : int
        {
            SW_HIDE = 0,
            SW_NORMAL = 1,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10
        }
        [Flags]
        enum MouseEventFlag : uint
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,
            VirtualDesk = 0x4000,
            Absolute = 0x8000,
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            //榜定全域鍵盤滑鼠事件
            HookManager.MouseMove += HookManager_MouseMove;
            HookManager.KeyDown += HookManager_KeyDown;
            lblIsStart.Text = string.Format("F5：開始。 F6：停止。目前狀態：{0}", IsStart ? "開始" : "停止");
        }

        #region 時間到執行
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            lblProcessTimes.Text = counter.ToString() + "次";

            //找到模擬器應用程式，同時讓他恢復顯示
            Process[] oProcess = Process.GetProcessesByName("HD-Frontend");
            if (oProcess.Length > 0)
            {
                ShowWindow(oProcess[0].MainWindowHandle, (int)DisplayType.SW_RESTORE);
                SetForegroundWindow(oProcess[0].MainWindowHandle);
                Thread.Sleep(3000);
            }
            else
            {
                lblProcessTimes.Text = "未找到指定目標！！";
                timer1.Stop();
            }

            //重新開始。
            for (int i = 0; i < 10; i++)
            {
                cmdMouseMove(tbxReStartPosition.Text);
                cmdMouseClick();
                Thread.Sleep(500);
            }

            //計時器時間1分鐘 = 60 秒 , 1秒 = 1000 毫秒。
            int WaitMinute = string.IsNullOrEmpty(tbxTime.Text.Trim()) ? 10 : Convert.ToInt16(tbxTime.Text.Trim());
            timer1.Interval = 60000 * WaitMinute;
        }
        #endregion

        #region 全域鍵盤滑鼠事件
        private void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePosition.Text = string.Format("x={0:0000}; y={1:0000}", e.X, e.Y);
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    IsStart = true;
                    lblIsStart.Text = string.Format("F5：開始。 F6：停止。目前狀態：{0}", IsStart ? "開始" : "停止");
                    tbxReStartPosition.Text = labelMousePosition.Text.Replace("x=", "").Replace("y=", "").Replace(";", ",");
                    tbxReStartPosition.Enabled = false;
                    tbxTime.Enabled = false;
                    HookManager.MouseMove -= HookManager_MouseMove;
                    timer1.Start();
                    break;
                case Keys.F6:
                    IsStart = false;
                    lblIsStart.Text = string.Format("F5：開始。 F6：停止。目前狀態：{0}", IsStart ? "開始" : "停止");
                    tbxReStartPosition.Enabled = true;
                    tbxTime.Enabled = true;
                    HookManager.MouseMove += HookManager_MouseMove;
                    timer1.Stop();
                    break;
            }
        }
        #endregion

        #region 模擬滑鼠按下相關
        //滑鼠移動到XY位置，用,分隔
        private void cmdMouseMove(string str)
        {
            string[] strs = str.Split(',');
            if (strs.Length == 2)
            {
                int x = int.Parse(strs[0]);
                int y = int.Parse(strs[1]);
                Cursor.Position = new Point(x, y);
            }
        }
        //滑鼠左鍵按下
        private void cmdMouseClick()
        {
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
        }
        #endregion
    }
}
