using System.Windows;

namespace Panuon.UI.Silver.Configurations
{
    public class PendingBoxSetting : DependencyObject
    {
        #region Ctor
        public PendingBoxSetting()
        {
            WindowStyle = (Style)Application.Current.FindResource(new ComponentResourceKey(typeof(PendingBox), "WindowStyle"));
            CancelButtonStyle = (Style)Application.Current.FindResource(new ComponentResourceKey(typeof(PendingBox), "CancelButtonStyle"));
            SpinStyle = (Style)Application.Current.FindResource(new ComponentResourceKey(typeof(PendingBox), "SpinStyle"));
            ContentTemplate = (DataTemplate)Application.Current.FindResource(new ComponentResourceKey(typeof(PendingBox), "ContentTemplate"));
        }
        #endregion

        #region Properties

        #region WindowStyle
        public Style WindowStyle
        {
            get { return (Style)GetValue(WindowStyleProperty); }
            set { SetValue(WindowStyleProperty, value); }
        }

        public static readonly DependencyProperty WindowStyleProperty =
            DependencyProperty.Register("WindowStyle", typeof(Style), typeof(PendingBoxSetting));
        #endregion

        #region CancelButtonStyle
        public Style CancelButtonStyle
        {
            get { return (Style)GetValue(CancelButtonStyleProperty); }
            set { SetValue(CancelButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty CancelButtonStyleProperty =
            DependencyProperty.Register("CancelButtonStyle", typeof(Style), typeof(PendingBoxSetting));
        #endregion

        #region SpinStyle
        public Style SpinStyle
        {
            get { return (Style)GetValue(SpinStyleProperty); }
            set { SetValue(SpinStyleProperty, value); }
        }

        public static readonly DependencyProperty SpinStyleProperty =
            DependencyProperty.Register("SpinStyle", typeof(Style), typeof(PendingBoxSetting));
        #endregion

        #region ContentTemplate
        public DataTemplate ContentTemplate
        {
            get { return (DataTemplate)GetValue(ContentTemplateProperty); }
            set { SetValue(ContentTemplateProperty, value); }
        }

        public static readonly DependencyProperty ContentTemplateProperty =
            DependencyProperty.Register("ContentTemplate", typeof(DataTemplate), typeof(PendingBoxSetting));
        #endregion

        #region CreateOnNewThread
        public bool CreateOnNewThread
        {
            get { return (bool)GetValue(CreateOnNewThreadProperty); }
            set { SetValue(CreateOnNewThreadProperty, value); }
        }

        public static readonly DependencyProperty CreateOnNewThreadProperty =
            DependencyProperty.Register("CreateOnNewThread", typeof(bool), typeof(PendingBoxSetting), new PropertyMetadata(true));
        #endregion

        #region InteropOwnersMask
        public bool InteropOwnersMask
        {
            get { return (bool)GetValue(InteropOwnersMaskProperty); }
            set { SetValue(InteropOwnersMaskProperty, value); }
        }

        public static readonly DependencyProperty InteropOwnersMaskProperty =
            DependencyProperty.Register("InteropOwnersMask", typeof(bool), typeof(PendingBoxSetting), new PropertyMetadata(true));
        #endregion
        
        #region CancelButtonContent
        public object CancelButtonContent
        {
            get { return (object)GetValue(CancelButtonContentProperty); }
            set { SetValue(CancelButtonContentProperty, value); }
        }

        public static readonly DependencyProperty CancelButtonContentProperty =
            DependencyProperty.Register("CancelButtonContent", typeof(object), typeof(PendingBoxSetting), new PropertyMetadata("Cancel"));
        #endregion
        
        #endregion
    }
}
