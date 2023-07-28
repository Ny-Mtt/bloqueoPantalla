using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Bloqueo
{
    class TheOne               
    {
        //constantes para posicionar sobre todo

        const int SWP_NOSIZE = 0x1;
        const int SWP_NOMOVE = 0X2;
        const int SWP_NOACTIVE = 0X10;
        const int wFlags = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVE;

        //valores de handInsertAfter
        const int HWND_TOPMOST = -1;
        const int HWND_NOTOPMOST = -2;

        // para mantener la ventana siempre visible
        [DllImport("user32.DLL")]

        private extern static void SetWindowPos(
            int hWnd, int hWndInsertAfter,
            int x, int y,
            int cx, int cy,
            int wFlags);

        public static void AboveAll(int handle)
        {
            SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, wFlags);
        }

    }
}
