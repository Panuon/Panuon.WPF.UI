using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using static Panuon.WPF.UI.Internal.Utils.Win32Util;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows;
using static Test.PInvoke.ParameterTypes;
using static Test.PInvoke.Methods;
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
}
