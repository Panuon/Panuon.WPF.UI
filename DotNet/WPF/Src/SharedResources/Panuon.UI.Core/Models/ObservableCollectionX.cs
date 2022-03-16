using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Panuon.UI.Core
{
    public class ObservableCollectionX<T> : ObservableCollection<T>
    {
        #region Ctor
        public ObservableCollectionX()
            : base()
        {

        }

        public ObservableCollectionX(IEnumerable<T> collection)
            : base(collection)
        {

        }
        #endregion

        #region Properties
        public bool HasItems => Items != null && Items.Any();
        #endregion

        #region Overrides
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(HasItems)));
        }
        #endregion

        #region Methods
        public new void Clear()
        {
            var items = Items.ToList();
            base.Clear();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, items));
        }
        #endregion
    }
}
