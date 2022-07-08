using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using static Panuon.WPF.UI.Internal.Utils.Win32Util;

namespace Panuon.WPF.UI
{
    public class AcrylicWindowXEffect : WindowXEffect
    {
        #region Fields
        private WindowX _windowX;
        #endregion

        #region Properties

        #region AccentColor
        public Color AccentColor
        {
            get { return (Color)GetValue(AccentColorProperty); }
            set { SetValue(AccentColorProperty, value); }
        }

        public static readonly DependencyProperty AccentColorProperty =
            DependencyProperty.Register("AccentColor", typeof(Color), typeof(AcrylicWindowXEffect), new PropertyMetadata(Colors.White, OnAccentColorChanged));
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

        #region Event Handlers
        private static void OnAccentColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var effect = (AcrylicWindowXEffect)d;
            effect.ResetWindowEffect(true);
        }
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
                var accentColor = AccentColor.R << 0 | AccentColor.G << 8 | AccentColor.B << 16 | AccentColor.A << 24;
                var handle = new WindowInteropHelper(_windowX).EnsureHandle();

                var accentPolicy = new AccentPolicy();
                if (enable)
                {
                    accentPolicy.AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND;
                    accentPolicy.GradientColor = accentColor;
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
