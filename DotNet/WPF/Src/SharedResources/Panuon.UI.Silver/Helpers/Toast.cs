using System;
using System.Collections.Generic;
using System.Text;

namespace Panuon.UI.Silver
{
    public static class Toast
    {
        #region Show
        public static void Show(WindowX window, string message)
        {
            ShowToast(window, message, MessageBoxIcon.None, ToastPlacement.Center, null);
        }

        public static void Show(WindowX window, string message, int duration)
        {
            ShowToast(window, message, MessageBoxIcon.None, ToastPlacement.Center, null);
        }

        public static void Show(WindowX window, string message, MessageBoxIcon icon)
        {
            ShowToast(window, message, icon, ToastPlacement.Center, null);
        }

        public static void Show(WindowX window, string message, MessageBoxIcon icon, int duration)
        {
            ShowToast(window, message, icon, ToastPlacement.Center, duration);
        }

        public static void Show(WindowX window, string message, ToastPlacement placement)
        {
            ShowToast(window, message, MessageBoxIcon.None, placement, null);
        }

        public static void Show(WindowX window, string message, ToastPlacement placement, int duration)
        {
            ShowToast(window, message, MessageBoxIcon.None, placement, duration);
        }

        public static void Show(WindowX window, string message, MessageBoxIcon icon, ToastPlacement placement)
        {
            ShowToast(window, message, icon, placement, null);
        }

        public static void Show(WindowX window, string message, MessageBoxIcon icon, ToastPlacement placement, int duration)
        {
            ShowToast(window, message, icon, placement, duration);
        }
        #endregion

        #region Function
        public static void ShowToast(WindowX window, string message, MessageBoxIcon icon, ToastPlacement placement, int? duration)
        {
            window.ShowToast(message, icon, placement, duration);
        }
        #endregion
    }
}