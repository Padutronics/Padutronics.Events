using System;
using System.Collections.Generic;
using System.Linq;

namespace Padutronics.Events;

public static class AsyncEventHandlerExtensions
{
    public static IEnumerable<AsyncEventHandler<TEventArgs>> GetHandlers<TEventArgs>(this AsyncEventHandler<TEventArgs> @this)
        where TEventArgs : EventArgs
    {
        return @this.GetInvocationList().Cast<AsyncEventHandler<TEventArgs>>();
    }
}