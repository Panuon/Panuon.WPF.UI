using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using static Panuon.WPF.UI.Internal.Utils.Win32Util;

namespace Panuon.WPF.UI
{
    public class AeroWindowXEffect : WindowXEffect
    {
        #region Fields
        private WindowX _windowX;
        #endregion

        #region Properties

        #region Brush
        public Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(AeroWindowXEffect), new PropertyMetadata(Brushes.White));
        #endregion

        #endregion

        #region Overrides

        #region Enable
        protected internal override void Enable(WindowX window)
        {
            _windowX = window;
            ResetWindowEffect(true);
        }
        #endregion


        #region OnDisabled
        protected internal override void Disable()
        {
            ResetWindowEffect(false);
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
                var handle = new WindowInteropHelper(_windowX).EnsureHandle();

                var accentPolicy = new AccentPolicy();
                if (enable)
                {
                    accentPolicy.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
                }
                else
                {
                    accentPolicy.AccentState = AccentState.ACCENT_DISABLED;
                }


                var accentPolicySize = Marshal.SizeOf(accentPolicy);
                var accentPtr = Marshal.AllocHGlobal(accentPolicySize);
                Marshal.StructureToPtr(accentPolicy, accentPtr, false);

                try
                {
                    var data = new WindowCompositionAttributeData
                    {
                        Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
                        SizeOfData = accentPolicySize,
                        Data = accentPtr,
                    };
                    SetWindowCompositionAttribute(handle, ref data);
                }
                finally
                {
                    // 释放非托管对象。
                    Marshal.FreeHGlobal(accentPtr);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to enable acrylic effects, an error occurred. " + ex);
            }

        }

        #endregion
    }
}
