using Panuon.WPF.UI;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Samples.Views.Examples
{
    /// <summary>
    /// FormView.xaml 的交互逻辑
    /// </summary>
    [ExampleView(Index = 3, DisplayName = "Form")]
    public partial class FormView : WindowX
    {
        #region Fields
        private bool _isProcessing;
        #endregion

        #region Ctor
        public FormView()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        protected override void OnClosing(CancelEventArgs e)
        {
            //Press Continue Button
            if (DialogResult == true)
            {
                if (_isProcessing)
                {
                    e.Cancel = true;
                    return;
                }
                if (!ValidateForm())
                {
                    e.Cancel = true;
                    return;
                }
                _isProcessing = true;
                var okButton = WindowXModalDialog.GetOKButton(this);
                ButtonHelper.SetIsPending(okButton, true);
                e.Cancel = true;
            }

            base.OnClosing(e);
        }
        #endregion

        #region Functions
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(TbName.Text))
            {
                FmgrpName.ValidateResult = ValidateResult.Error;
                FmgrpName.Message = "Input your name.";
                return false;
            }
            FmgrpName.ValidateResult = ValidateResult.None;
            FmgrpName.Message = null;

            if (ChbAgreement.IsChecked != true)
            {
                FmgrpOptions.ValidateResult = ValidateResult.Error;
                FmgrpOptions.Message = "Check option(s).";
                return false;
            }
            FmgrpOptions.ValidateResult = ValidateResult.None;
            FmgrpOptions.Message = null;
            return true;
        }
        #endregion

    }
}
