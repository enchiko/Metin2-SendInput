using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace METININPUT
{
    public class User
    {
     
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(int int_11);

        [DllImport("user32")]
        public static extern int GetWindow(int int_11, int int_12);

        [DllImport("user32")]
        public static extern int GetDesktopWindow();

        [DllImport("user32")]
        public static extern int IsWindowVisible(int int_11);

        [DllImport("User32.Dll")]
        public static extern void GetWindowText(int int_11, StringBuilder stringBuilder_0, int int_12);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(int hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int GetForegroundWindow();

    }
}
