using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using static Panuon.UI.Silver.Internal.Utils.Win32Util;

namespace Panuon.UI.Silver
{
    public class AcrylicWindowXEffect : WindowXEffect
    {
        #region Fields
        private WindowX _windowX;
        #endregion

        #region Properties

        #region Color
        public Color BlurColor
        {
            get { return (Color)GetValue(BlurColorProperty); }
            set { SetValue(BlurColorProperty, value); }
        }

        public static readonly DependencyProperty BlurColorProperty =
            DependencyProperty.Register("BlurColor", typeof(Color), typeof(AcrylicWindowXEffect), new PropertyMetadata(Colors.White, OnBlurColorChanged));
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
        private static void OnBlurColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
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
                var blurColor = BlurColor.R << 0 | BlurColor.G << 8 | BlurColor.B << 16 | BlurColor.A << 24;
                var handle = new WindowInteropHelper(_windowX).EnsureHandle();

                var accentPolicy = new AccentPolicy();
                if (enable)
                {
                    accentPolicy.AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND;
                    accentPolicy.GradientColor = blurColor;
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
