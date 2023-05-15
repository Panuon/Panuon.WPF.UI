using Panuon.WPF.UI;
using System.Windows;

namespace Samples.Views.Examples
{
    /// <summary>
    /// Interaction logic for SignInView.xaml
    /// </summary>
    [ExampleView(Index = 2, DisplayName = "Sign In")]
    public partial class SignInView : WindowX
    {
        #region Fields
        private bool _isProcessing;
        #endregion

        #region Ctor
        public SignInView()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (_isProcessing)
            {
                return;
            }
            if (!ValidateAccount()
                || !ValidatePassword())
            {
                return;
            }
            _isProcessing = true;
            ButtonHelper.SetIsPending(BtnLogin, true);
            FrmPassword.ValidateResult = ValidateResult.None;
            FrmPassword.Message = null;
        }

        private void TbAccount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ValidateAccount();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ValidatePassword();
        }
        #endregion

        #region Functions
        private bool ValidateAccount()
        {
            if (TbAccount.Text == null 
                || TbAccount.Text == "")
            {
                FrmAccount.ValidateResult = ValidateResult.Error;
                FrmAccount.Message = "Try to input account.";
                return false;
            }
            FrmAccount.ValidateResult = ValidateResult.Success;
            FrmAccount.Message = "Account valid.";

            return true;
        }

            private bool ValidatePassword()
        {
            if (PwdPassword.Password == null 
                || PwdPassword.Password == "")
            {
                FrmPassword.ValidateResult = ValidateResult.Error;
                FrmPassword.Message = "Try to input password.";
                return false;
            }
            else if (PwdPassword.Password.Length < 6)
            {
                FrmPassword.ValidateResult = ValidateResult.Error;
                FrmPassword.Message = "At least 6 digits.";
                return false;
            }
            else if (PwdPassword.Password != "123456")
            {
                FrmPassword.ValidateResult = ValidateResult.Warning;
                FrmPassword.Message = "Password should be 123456.";
                return false;
            }
            else
            {
                FrmPassword.ValidateResult = ValidateResult.Success;
                FrmPassword.Message = "Password valid.";
                return true;
            }
        }
        #endregion

    }
}
