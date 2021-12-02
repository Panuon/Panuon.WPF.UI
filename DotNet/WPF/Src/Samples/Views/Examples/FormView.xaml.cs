using Panuon.UI.Silver;
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
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            if (_isProcessing)
            {
                return;
            }
            if (!ValidateForm())
            {
                return;
            }
            _isProcessing = true;
            ButtonHelper.SetIsPending(BtnContinue, true);
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
