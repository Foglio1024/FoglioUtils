﻿using System.Windows.Threading;

namespace Nostrum.WPF.Extensions
{
    public static class DispatcherTimerExtensions
    {
        /// <summary>
        /// Stops and restarts the timer.
        /// </summary>
        public static void Refresh(this DispatcherTimer t)
        {
            t.Stop();
            t.Start();
        }
    }
}