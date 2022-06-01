using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class NotifyCollection<T> : INotifyCollection<T>
    {
        private ICollection<T> _devices;
        public int Count => _devices.Count;

        public bool IsReadOnly => false;

        public event EventHandler<T> AddEvent;
        public event EventHandler<T> RemoveEvent;

        public NotifyCollection(ICollection<T> devices)
        {
            _devices = devices;
        }

        protected virtual void OnAddEvent(object sender, T arg)
        {
            AddEvent?.Invoke(sender, arg);
        }

        protected virtual void OnRemoveEvent(object sender, T arg)
        {
            RemoveEvent?.Invoke(sender, arg);
        }


        public void Add(T item)
        {
            _devices.Add(item);
            OnAddEvent(this, item);
        }

        public void Clear()
        {
            _devices.Clear();
        }

        public bool Contains(T item)
        {
            return _devices.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _devices.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _devices.GetEnumerator();
        }

        public bool Remove(T item)
        {
            var temp = _devices.Remove(item);
            if (temp)
            {
                OnRemoveEvent(this, item);
            }
            return temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
