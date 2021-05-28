using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Panuon.UI.Core
{
    public class ObservableCollectionX<T> : ObservableCollection<T>
    {
        public new void Clear()
        {
            var items = Items.ToList();
            base.Clear();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, items));
        }
    }
}
