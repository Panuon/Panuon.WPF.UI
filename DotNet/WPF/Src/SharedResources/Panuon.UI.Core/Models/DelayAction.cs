using System;
using System.Threading;

namespace Panuon.UI.Core
{
    public class DelayAction
    {
        #region Fields
        private Timer _timer;

        private Action _action;

        private int _delayMillionSeconds;
        #endregion

        #region Ctor
        public DelayAction(int delayMillionSeconds, 
            Action action)
        {
            _delayMillionSeconds = delayMillionSeconds;
            _action = action;
            _timer = new Timer(OnTimerTicked, null, Timeout.Infinite, Timeout.Infinite);
        }
        #endregion

        #region Methods
        public void StartOrRefresh()
        {
            _timer.Change(_delayMillionSeconds, Timeout.Infinite);
        }

        public void Cancel()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
        #endregion

        #region Functions
        private void OnTimerTicked(object state)
        {
            _action?.Invoke();
        }
        #endregion

    }
}
