using Panuon.UI.Silver.Configurations;
using Panuon.UI.Silver.Internal.Controls;
using System.Windows;

namespace Panuon.UI.Silver
{
    public static class MessageBoxX
    {
        #region Methods
        /// <summary>
        /// Open a message box .
        /// </summary>
        /// <param name="message">Text to display.</param>
        public static MessageBoxResult Show(string message)
        {
            return CallMessageBoxXWindow(null, message, null, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        public static MessageBoxResult Show(Window owner, string message)
        {
            return CallMessageBoxXWindow(owner, message, null, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        public static MessageBoxResult Show(Window owner, string message, MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, null, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, setting);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        public static MessageBoxResult Show(string message, string caption)
        {
            return CallMessageBoxXWindow(null, message, caption, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(null, message, caption, MessageBoxButton.OK, MessageBoxIcon.None, DefaultButton.Unset, setting);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        public static MessageBoxResult Show(string message, string caption, MessageBoxButton button)
        {
            return CallMessageBoxXWindow(null, message, caption, button, MessageBoxIcon.None, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxButton button)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, MessageBoxIcon.None, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxButton button, MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, MessageBoxIcon.None, DefaultButton.Unset, setting);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(string message, MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(null, message, null, MessageBoxButton.OK, icon, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner, string message, MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(owner, message, null, MessageBoxButton.OK, icon, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(string message, string caption, MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(null, message, caption, MessageBoxButton.OK, icon, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, icon, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxIcon icon, MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, MessageBoxButton.OK, icon, DefaultButton.Unset, setting);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(string message, string caption, MessageBoxButton button, MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(null, message, caption, button, icon, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxButton button, MessageBoxIcon icon)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, DefaultButton.Unset, null);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="owner">The owner of message box.</param>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxButton button, MessageBoxIcon icon, MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, DefaultButton.Unset, setting);
        }

        /// <summary>
        /// Open a message box and return the result selected by the user.
        /// </summary>
        /// <param name="message">Text to display.</param>
        /// <param name="caption">The title of message box.</param>
        /// <param name="button">The group of buttons to display in the message box.</param>
        /// <param name="icon">Large icon displayed on the left side of the message box.</param>
        /// <param name="defaultButton">The default button. Buttons set as default will be highlighted.</param>
        public static MessageBoxResult Show(string message, string caption, MessageBoxButton button, MessageBoxIcon icon, DefaultButton defaultButton)
        {
            return CallMessageBoxXWindow(null, message, caption, button, icon, defaultButton, null);
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
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxButton button, MessageBoxIcon icon, DefaultButton defaultButton)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, defaultButton, null);
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
        public static MessageBoxResult Show(Window owner, string message, string caption, MessageBoxButton button, MessageBoxIcon icon, DefaultButton defaultButton, MessageBoxXSetting setting)
        {
            return CallMessageBoxXWindow(owner, message, caption, button, icon, defaultButton, setting);
        }
        #endregion

        #region Functions
        private static MessageBoxResult CallMessageBoxXWindow(Window owner, string message, string caption, MessageBoxButton button, MessageBoxIcon icon, DefaultButton defaultButton, MessageBoxXSetting setting)
        {
            var window = new MessageBoxXWindow(message, caption, button, icon, defaultButton, owner, setting ?? MessageBoxXSettings.Setting);
            window.ShowDialog();
            return window.Result;
        }
        #endregion
    }
}
