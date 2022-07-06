using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Controls;
using System.Windows;

namespace Panuon.UI.Silver
{
    public static class MessageBoxX
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey ButtonStyle { get; } =
            new ComponentResourceKey(typeof(MessageBoxX), nameof(ButtonStyle));

        public static ComponentResourceKey ContentTemplate { get; } =
           new ComponentResourceKey(typeof(MessageBoxX), nameof(ContentTemplate));
        
        public static ComponentResourceKey WindowXStyle { get; } =
            new ComponentResourceKey(typeof(MessageBoxX), nameof(WindowXStyle));
        #endregion

        #region Methods
        /// <summary>
        /// Open a message box .
        /// </summary>
        /// <param name="message">Text to display.</param>
        public static MessageBoxResult Show(string message)
        {
            return CallMessageBoxXWindow(null, message, null, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        public static MessageBoxResult Show(Window owner,
            string message)
        {
            return CallMessageBoxXWindow(owner, message, null, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, null, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, setting, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        public static MessageBoxResult Show(string message,
            string caption)
        {
            return CallMessageBoxXWindow(null, message, caption, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            string caption)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, setting, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        public static MessageBoxResult Show(string message,
            string caption,
            MessageBoxButton button)
        {
            return CallMessageBoxXWindow(null, message, caption, button, MessageBoxIcon.None, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxButton button)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, MessageBoxIcon.None, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxButton button,
            MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, MessageBoxIcon.None, DefaultButton.Unset, setting, null);
        }


        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(string message,
            MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(null, message, null, MessageBoxButton.OK, icon, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(owner, message, null, MessageBoxButton.OK, icon, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(string message,
            string caption,
            MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(null, message, caption, MessageBoxButton.OK, icon, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner, 
            string message,
            string caption,
            MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, icon, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message, 
            string caption,
            MessageBoxIcon icon,
            MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, icon, DefaultButton.Unset, setting, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(string message, 
            string caption, 
            MessageBoxButton button, 
            MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(null, message, caption, button, icon, DefaultButton.Unset, null, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxButton button,
            MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, DefaultButton.Unset, null,null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            string caption, 
            MessageBoxButton button,
            MessageBoxIcon icon, 
            MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, DefaultButton.Unset, setting, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        /// <param name="defaultButton">The default button. Buttons set as default will be highlighted.</param>
        public static MessageBoxResult Show(string message, 
            string caption, 
            MessageBoxButton button,
            MessageBoxIcon icon, 
            DefaultButton defaultButton)
        {
            return CallMessageBoxXWindow(null, message, caption, button, icon, defaultButton, null, null);
        }

        public static MessageBoxResult Show(string message,
            string caption,
            MessageBoxButton button,
            MessageBoxIcon icon,
            DefaultButton defaultButton,
            int countdown)
        {
            return CallMessageBoxXWindow(null, message, caption, button, icon, defaultButton, null, countdown);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        /// <param name="defaultButton">The default button. Buttons set as default will be highlighted.</param>
        public static MessageBoxResult Show(Window owner, 
            string message,
            string caption, 
            MessageBoxIcon icon, 
            DefaultButton defaultButton)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, icon, defaultButton, null, null);
        }

        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxIcon icon,
            DefaultButton defaultButton,
            int countdown)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, icon, defaultButton, null, countdown);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        /// <param name="defaultButton">The default button. Buttons set as default will be highlighted.</param>
        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxButton button, 
            MessageBoxIcon icon, 
            DefaultButton defaultButton)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, defaultButton, null, null);
        }

        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxButton button,
            MessageBoxIcon icon,
            DefaultButton defaultButton,
            int countdown)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, defaultButton, null, countdown);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        /// <param name="defaultButton">The default button. Buttons set as default will be highlighted.</param>
        public static MessageBoxResult Show(Window owner, 
            string message, 
            string caption,
            MessageBoxButton button, 
            MessageBoxIcon icon,
            DefaultButton defaultButton,
            MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, defaultButton, setting, null);
        }

        public static MessageBoxResult Show(Window owner,
            string message,
            string caption,
            MessageBoxButton button,
            MessageBoxIcon icon,
            DefaultButton defaultButton,
            MessageBoxXSetting setting,
            int countdown)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, defaultButton, setting, countdown);
        }
        #endregion

        #region Functions
        private static MessageBoxResult CallMessageBoxXWindow(Window owner
            , string message
            , string caption
            , MessageBoxButton button
            , MessageBoxIcon icon
            , DefaultButton defaultButton
            , MessageBoxXSetting setting
            , int? countdown)
        {
            if(defaultButton == DefaultButton.Unset
                && countdown != null)
            {
                throw new System.Exception("MessageBoxX : When using the countdown parameter, the value of the defaultButton parameter cannot be Unset.");
            }
            var window = new MessageBoxXWindow(message, caption, button, icon, defaultButton, owner, setting ?? MessageBoxXSettings.Setting, countdown);
            var dialogResult = window.ShowDialog();
            switch (dialogResult)
            {
                case true:
                    return (button == MessageBoxButton.YesNo || button == MessageBoxButton.YesNoCancel)
                        ? MessageBoxResult.Yes
                        : MessageBoxResult.OK;
                case false:
                    return MessageBoxResult.No;
                default:
                    return MessageBoxResult.Cancel;
            }
        }
        #endregion
    }
}
