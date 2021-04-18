using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Samples.Views.Examples
{
    /// <summary>
    /// Interaction logic for SignInView.xaml
    /// </summary>
    [ExampleView(Index = 2, DisplayName = "Sign In")]
    public partial class SignInView : WindowX
    {
        private bool _isProgressing;

        public SignInView()
        {
            InitializeComponent();
            ValidatePassword();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (_isProgressing)
            {
                return;
            }
            if (!ValidatePassword())
            {
                return;
            }
            _isProgressing = true;
            ButtonHelper.SetIsPending(BtnLogin, true);
            FmgPassword.ValidateResult = ValidateResult.None;
            FmgPassword.Message = null;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ValidatePassword();
        }

        private bool ValidatePassword()
        {
            if (PwdPassword.Password == null || PwdPassword.Password == "")
            {
                FmgPassword.ValidateResult = ValidateResult.Info;
                FmgPassword.Message = "Try to input password";
                return false;
            }
            else if (PwdPassword.Password.Length < 6)
            {
                FmgPassword.ValidateResult = ValidateResult.Error;
                FmgPassword.Message = "At least 6 digits.";
                return false;
            }
            else if (PwdPassword.Password != "123456")
            {
                FmgPassword.ValidateResult = ValidateResult.Warning;
                FmgPassword.Message = "Password should be 123456.";
                return false;
            }
            else
            {
                FmgPassword.ValidateResult = ValidateResult.Success;
                FmgPassword.Message = "Nice work.";
                return true;
            }
        }
    }
}
