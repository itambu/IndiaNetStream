using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public interface INotifyCollection<T> : ICollection<T>
    {
        event EventHandler<T> AddEvent;
        event EventHandler<T> RemoveEvent;
    }
}
