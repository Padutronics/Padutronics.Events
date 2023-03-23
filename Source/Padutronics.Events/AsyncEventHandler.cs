using System;
using System.Threading.Tasks;

namespace Padutronics.Events;

public delegate Task AsyncEventHandler<TEventArgs>(object? sender, TEventArgs e)
    where TEventArgs : EventArgs;