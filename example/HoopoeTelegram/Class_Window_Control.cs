namespace HoopoeTelegram
{
    using System;
    using System.Diagnostics;
    using System.Management;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;

    internal class Class_Window_Control
    {
        public const int HT_CAPTION = 2;
        private const int KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYDOWN = 0;
        private const int KEYEVENTF_KEYUP = 2;
        public static uint maptype;
        private const int MOUSEEVENTF_LBUTTONDBLCLK = 0x203;
        private const int MOUSEEVENTF_LBUTTONDOWN = 0x201;
        private const int MOUSEEVENTF_LBUTTONUP = 0x202;
        private const int MOUSEEVENTF_MBUTTONDBLCLK = 0x209;
        private const int MOUSEEVENTF_MBUTTONDOWN = 0x207;
        private const int MOUSEEVENTF_MBUTTONUP = 520;
        private const int MOUSEEVENTF_MOUSEHWHEEL = 0x20e;
        private const int MOUSEEVENTF_MOUSEMOVE = 0x200;
        private const int MOUSEEVENTF_MOUSEWHEEL = 0x20a;
        private const int MOUSEEVENTF_RBUTTONDBLCLK = 0x206;
        private const int MOUSEEVENTF_RBUTTONDOWN = 0x204;
        private const int MOUSEEVENTF_RBUTTONUP = 0x205;
        private const int MOUSEEVENTF_XBUTTONDBLCLK = 0x20d;
        private const int MOUSEEVENTF_XBUTTONDOWN = 0x20b;
        private const int MOUSEEVENTF_XBUTTONUP = 0x20c;
        private const int SC_CLOSE = 0xf060;
        private const int VK_CAPITAL = 20;
        private const int VK_CONTROL = 0x11;
        private const int VK_MENU = 0x12;
        private const int VK_PAUSE = 0x13;
        private const int VK_RCONTROL = 3;
        private const int VK_SHIFT = 0x10;
        private const int WM_CHAR = 0x102;
        private const int WM_KEYDOWN = 0x100;
        public const int WM_NCLBUTTONDOWN = 0xa1;
        private const int WM_PASTE = 770;
        private const int WM_SYSCOMMAND = 0x112;
        private const int WM_SYSKEYDOWN = 260;
        private const int WM_SYSKEYUP = 0x105;

        public static void close_all_process_advance(string exe_filename)
        {
            ManagementScope scope = new ManagementScope();
            scope.Connect();
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Process Where Name='" + exe_filename + ".exe' ");
            foreach (ManagementObject obj2 in new ManagementObjectSearcher(scope, query).Get())
            {
                try
                {
                    Process.GetProcessById(int.Parse(obj2["ProcessId"].ToString())).Kill();
                }
                catch
                {
                }
            }
        }

        public static void Close_Window(int Handle)
        {
            try
            {
                Close_Window((IntPtr) Handle);
            }
            catch
            {
            }
        }

        public static void Close_Window(IntPtr Handle)
        {
            SendMessage(Handle, 0x112, (IntPtr) 0xf060, IntPtr.Zero);
        }

        public static void Close_Window(string Handle)
        {
            try
            {
                Close_Window((IntPtr) int.Parse(Handle));
            }
            catch
            {
            }
        }

        public static void close_Window_By_Caption(string caption)
        {
            Close_Window(FindWindow(null, caption));
        }

        public static string Decimal_To_HEX1(int dc)
        {
            try
            {
                return dc.ToString("X");
            }
            catch
            {
            }
            return "";
        }

        public static void Enable_Diable_Window(IntPtr handle, bool enable)
        {
            try
            {
                EnableWindow(handle, enable);
            }
            catch
            {
            }
        }

        public static void Enable_Diable_Window(string handle, bool enable)
        {
            try
            {
                EnableWindow((IntPtr) int.Parse(handle), enable);
            }
            catch
            {
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        private static extern bool EnableWindow(IntPtr hWnd, bool bEnable);
        public static IntPtr find_Window_Handle_By_Caption(string caption)
        {
            return FindWindow(null, caption);
        }

        [DllImport("user32.dll", SetLastError=true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint="FindWindow", SetLastError=true)]
        private static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);
        public static int Get_MainWindow_Handle(IntPtr handle)
        {
            return Process.GetProcessById((int) Get_Window_ProcessId_By_Handle(handle)).Id;
        }

        public static uint Get_Window_ProcessId_By_Handle(IntPtr handle)
        {
            uint lpdwProcessId = 0;
            GetWindowThreadProcessId(handle, out lpdwProcessId);
            return lpdwProcessId;
        }

        [DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);
        public static string GetClassName_of_Window(IntPtr Handle)
        {
            try
            {
                StringBuilder lpClassName = new StringBuilder(0x100);
                GetClassName(Handle, lpClassName, lpClassName.Capacity);
                return lpClassName.ToString();
            }
            catch
            {
            }
            return "";
        }

        public static string GetClassName_of_Window(string Handle)
        {
            try
            {
                return GetClassName_of_Window((IntPtr) int.Parse(Handle));
            }
            catch
            {
            }
            return "";
        }

        [DllImport("user32.dll")]
        private static extern int GetWindowModuleFileName(IntPtr hWnd, StringBuilder title, int size);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll")]
        private static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);
        [DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll", SetLastError=true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        public static int HEX_to_Decimal1(string hx)
        {
            try
            {
                return Convert.ToInt32(hx, 0x10);
            }
            catch
            {
            }
            return 0;
        }

        public static bool is_Minimize_To_TaskBar(string Process_Name, string className)
        {
            try
            {
                return IsIconic(FindWindow(className.Trim(), Process_Name.Trim()));
            }
            catch
            {
            }
            return false;
        }

        public static bool is_Window_Maximize(string Process_Name, string className)
        {
            WINDOWPLACEMENT lpwndpl = new WINDOWPLACEMENT();
            GetWindowPlacement(FindWindow(className.Trim(), Process_Name.Trim()), ref lpwndpl);
            return (lpwndpl.showCmd == 3);
        }

        public static bool is_Window_Minimize(string Process_Name, string className)
        {
            WINDOWPLACEMENT lpwndpl = new WINDOWPLACEMENT();
            GetWindowPlacement(FindWindow(className.Trim(), Process_Name.Trim()), ref lpwndpl);
            return (lpwndpl.showCmd == 2);
        }

        public static bool is_Window_Normal(string Process_Name, string className)
        {
            WINDOWPLACEMENT lpwndpl = new WINDOWPLACEMENT();
            GetWindowPlacement(FindWindow(className.Trim(), Process_Name.Trim()), ref lpwndpl);
            return (lpwndpl.showCmd == 1);
        }

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte key, byte scan, int flags, int extraInfo);
        public static IntPtr MakeLParam(int wLow, int wHigh)
        {
            return (IntPtr) ((((short) wHigh) << 0x10) | (wLow & 0xffff));
        }

        [DllImport("user32.dll")]
        private static extern byte MapVirtualKey(byte uCode, uint uMapType);
        [DllImport("user32.dll", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Auto)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        public static void MoveForm_With_MouseDown_Event(Form form, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0xa1, (IntPtr) 2, IntPtr.Zero);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public static void Set_Parent_And_Chid(IntPtr parent, IntPtr chid)
        {
            try
            {
                SetParent(chid, parent);
            }
            catch
            {
            }
        }

        public static void Set_Parent_And_Chid(IntPtr parent, string chid)
        {
            try
            {
                Set_Parent_And_Chid(parent, (IntPtr) int.Parse(chid));
            }
            catch
            {
            }
        }

        public static void Set_Window_Position(IntPtr app_hwnd, int top, int left, int right, int bottom)
        {
            WINDOWPLACEMENT lpwndpl = new WINDOWPLACEMENT();
            GetWindowPlacement(app_hwnd, ref lpwndpl);
            lpwndpl.rcNormalPosition.top = top;
            lpwndpl.rcNormalPosition.left = left;
            lpwndpl.rcNormalPosition.right = right;
            lpwndpl.rcNormalPosition.bottom = bottom;
            SetWindowPlacement(app_hwnd, ref lpwndpl);
        }

        public static void Set_Window_Position(string Process_Name, string className, int top, int left, int right, int bottom)
        {
            WINDOWPLACEMENT lpwndpl = new WINDOWPLACEMENT();
            IntPtr hWnd = FindWindow(className.Trim(), Process_Name.Trim());
            GetWindowPlacement(hWnd, ref lpwndpl);
            lpwndpl.rcNormalPosition.top = top;
            lpwndpl.rcNormalPosition.left = left;
            lpwndpl.rcNormalPosition.right = right;
            lpwndpl.rcNormalPosition.bottom = bottom;
            SetWindowPlacement(hWnd, ref lpwndpl);
        }

        public static void Set_window_State(IntPtr app_hwnd, window_state win_state)
        {
            WINDOWPLACEMENT lpwndpl = new WINDOWPLACEMENT();
            GetWindowPlacement(app_hwnd, ref lpwndpl);
            lpwndpl.showCmd = (int) win_state;
            SetWindowPlacement(app_hwnd, ref lpwndpl);
        }

        public static void Set_window_State(string Process_Name, window_state win_state)
        {
            foreach (Process process in Process.GetProcessesByName(Process_Name.Trim()))
            {
                WINDOWPLACEMENT lpwndpl = new WINDOWPLACEMENT();
                IntPtr mainWindowHandle = process.MainWindowHandle;
                GetWindowPlacement(mainWindowHandle, ref lpwndpl);
                lpwndpl.showCmd = (int) win_state;
                SetWindowPlacement(mainWindowHandle, ref lpwndpl);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError=true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        public static void SetWindow_ForeGround_Window(string Process_Name, string className)
        {
            try
            {
                SetForegroundWindow(FindWindow(className.Trim(), Process_Name.Trim()));
            }
            catch
            {
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        public enum chane_window_visibility
        {
            NoCahnge,
            Hide,
            Show
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINTAPI
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public enum window_state
        {
            HIDE = 0,
            MAXIMIZE = 3,
            MINIMIZE = 6,
            NORMAL = 1,
            RESTORE = 9,
            SHOW = 5,
            SHOWMAXIMIZED = 3,
            SHOWMINIMIZED = 2,
            SHOWMINNOACTIVE = 7,
            SHOWNA = 8,
            SHOWNOACTIVATE = 4,
            SHOWNORMAL = 1
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public Class_Window_Control.POINTAPI ptMinPosition;
            public Class_Window_Control.POINTAPI ptMaxPosition;
            public Class_Window_Control.RECT rcNormalPosition;
        }
    }
}

