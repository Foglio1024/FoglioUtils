﻿using System;
using System.Runtime.InteropServices;

namespace Nostrum.WinAPI
{
    public static class Gdi32
    {
        [DllImport("gdi32")]
        public static extern int DeleteObject(IntPtr o);

    }
}