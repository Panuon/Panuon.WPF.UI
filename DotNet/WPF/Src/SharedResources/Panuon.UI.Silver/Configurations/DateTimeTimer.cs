using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Panuon.UI.Silver.Configurations
{
    public class DateTimeTimer : DependencyObject
    {
        #region Fields
        private Timer _timer;
        #endregion

        #region Ctor
        public DateTimeTimer()
        {
            _timer = new Timer(OnTimerTicked, null, 0, Timeout.Infinite);
        }
        #endregion

        #region Properties

        #region Now
        public DateTime Now
        {
            get { return (DateTime)GetValue(NowProperty); }
            set { SetValue(NowProperty, value); }
        }

        public static readonly DependencyProperty NowProperty =
            DependencyProperty.Register("Now", typeof(DateTime), typeof(DateTimeTimer));
        #endregion

        #endregion

        #region Event Handlers
        private void OnTimerTicked(object state)
        {
            try
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    Now = DateTime.Now;
                }));
            }
            catch { }
            _timer.Change(1000 - DateTime.Now.Millisecond, Timeout.Infinite);
        }
        #endregion

    }
}
