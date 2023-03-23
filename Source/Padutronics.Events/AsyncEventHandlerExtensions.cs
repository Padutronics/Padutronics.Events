using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padutronics.Events;

public static class AsyncEventHandlerExtensions
{
    public static IEnumerable<AsyncEventHandler<TEventArgs>> GetHandlers<TEventArgs>(this AsyncEventHandler<TEventArgs> @this)
        where TEventArgs : EventArgs
    {
        return @this.GetInvocationList().Cast<AsyncEventHandler<TEventArgs>>();
    }

    public static Task InvokeAllAsync<TEventArgs>(this AsyncEventHandler<TEventArgs> @this, object? sender, TEventArgs e)
        where TEventArgs : EventArgs
    {
        return Task.WhenAll(GetHandlers(@this).Select(handler => handler(sender, e)));
    }
}