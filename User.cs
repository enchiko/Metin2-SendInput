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
        public static extern int SetForegroundWindow(int id);

        [DllImport("user32")]
        public static extern int GetWindow(int id, int uCmd);

        [DllImport("user32")]
        public static extern int GetDesktopWindow();

        [DllImport("user32")]
        public static extern int IsWindowVisible(int id);

        [DllImport("User32.Dll")]
        public static extern void GetWindowText(int id, StringBuilder sBuilder, int sBuilderCapacity);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(int hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int GetForegroundWindow();

    }
}
