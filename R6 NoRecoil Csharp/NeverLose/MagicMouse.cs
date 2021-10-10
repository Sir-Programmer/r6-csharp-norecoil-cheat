using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NeverLose
{
    class MagicMouse
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        public static int _ScreenWidth { get; } = Screen.PrimaryScreen.Bounds.Width;
        public static int _ScreenHeight { get; } = Screen.PrimaryScreen.Bounds.Height;
        public static int _ScreenCenterX { get; } = _ScreenWidth / 2;
        public static int _ScreenCenterY { get; } = _ScreenHeight / 2;
        public static bool bGetAsyncKeyState(Keys vKey)
        {
            int x = GetAsyncKeyState(vKey);
            if ((x == 1) || (x == Int16.MinValue))
                return true;
            else
                return false;
        }

        private const int MOUSEEVENTF_MOVE = 0x0001;

        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }
    }
}
