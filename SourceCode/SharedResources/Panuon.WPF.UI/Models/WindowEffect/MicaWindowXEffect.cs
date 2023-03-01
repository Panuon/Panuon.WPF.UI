using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using static Panuon.WPF.UI.Internal.Utils.Win32Util;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows;
using static Panuon.WPF.UI.PInvoke.ParameterTypes;
using static Panuon.WPF.UI.PInvoke.Methods;
using System.Windows.Shell;

namespace Panuon.WPF.UI
{
    public class MicaWindowXEffect : WindowXEffect
    {
        #region Fields
        private WindowX _windowX;
        #endregion

        #region Properties

        #endregion

        #region Overrides

        #region Enable
        protected internal override void Enable(WindowX window)
        {
            _windowX = window;
            if (_windowX.IsLoaded)
            {
                ResetWindowEffect(true);
            }
            else
            {
                _windowX.Loaded += (s, e) =>
                {
                    ResetWindowEffect(true);
                };
            }
        }
        #endregion


        #region OnDisabled
        protected internal override void Disable()
        {
            if (_windowX.IsLoaded)
            {
                ResetWindowEffect(false);
            }
            else
            {
                _windowX.Loaded += (s, e) =>
                {
                    ResetWindowEffect(false);
                };
            }
        }
        #endregion

        #endregion

        #region Functions
        private void ResetWindowEffect(bool enable)
        {
            if (_windowX == null)
            {
                return;
            }

            try
            {
                _windowX.Background = Brushes.Transparent;
                var windowChrome = WindowChrome.GetWindowChrome(_windowX);
                windowChrome.GlassFrameThickness = new Thickness(-1);

                IntPtr mainWindowPtr = new WindowInteropHelper(_windowX).Handle;
                HwndSource mainWindowSrc = HwndSource.FromHwnd(mainWindowPtr);
                mainWindowSrc.CompositionTarget.BackgroundColor = Color.FromArgb(0, 0, 0, 0);

                MARGINS margins = new MARGINS();
                margins.cxLeftWidth = -1;
                margins.cxRightWidth = -1;
                margins.cyTopHeight = -1;
                margins.cyBottomHeight = -1;

                ExtendFrame(mainWindowSrc.Handle, margins);

                var isDark = true;
                int flag = isDark ? 1 : 0;
                SetWindowAttribute(
                    new WindowInteropHelper(_windowX).Handle,
                    DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE,
                    flag);

                int type = 2;
                SetWindowAttribute(
                    new WindowInteropHelper(_windowX).Handle,
                    DWMWINDOWATTRIBUTE.DWMWA_SYSTEMBACKDROP_TYPE,
                    type);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to enable mica effects, an error occurred. " + ex);
            }

        }

        #endregion
    }


    public class PInvoke
    {
        public class ParameterTypes
        {
            /*
            [Flags]
            enum DWM_SYSTEMBACKDROP_TYPE
            {
                DWMSBT_MAINWINDOW = 2, // Mica
                DWMSBT_TRANSIENTWINDOW = 3, // Acrylic
                DWMSBT_TABBEDWINDOW = 4 // Tabbed
            }
            */

            [Flags]
            public enum DWMWINDOWATTRIBUTE
            {
                DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
                DWMWA_SYSTEMBACKDROP_TYPE = 38
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct MARGINS
            {
                public int cxLeftWidth;      // width of left border that retains its size
                public int cxRightWidth;     // width of right border that retains its size
                public int cyTopHeight;      // height of top border that retains its size
                public int cyBottomHeight;   // height of bottom border that retains its size
            };
        }

        public static class Methods
        {
            [DllImport("DwmApi.dll")]
            static extern int DwmExtendFrameIntoClientArea(
                IntPtr hwnd,
                ref ParameterTypes.MARGINS pMarInset);

            [DllImport("dwmapi.dll")]
            static extern int DwmSetWindowAttribute(IntPtr hwnd, ParameterTypes.DWMWINDOWATTRIBUTE dwAttribute, ref int pvAttribute, int cbAttribute);

            public static int ExtendFrame(IntPtr hwnd, ParameterTypes.MARGINS margins)
                => DwmExtendFrameIntoClientArea(hwnd, ref margins);

            public static int SetWindowAttribute(IntPtr hwnd, ParameterTypes.DWMWINDOWATTRIBUTE attribute, int parameter)
                => DwmSetWindowAttribute(hwnd, attribute, ref parameter, Marshal.SizeOf<int>());
        }

    }
}
