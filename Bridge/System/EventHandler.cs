using Bridge;

namespace System
{
    /// <summary>
    /// Represents the method that will handle an event that has no event data.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An System.EventArgs that contains no event data.</param>
    [External]
    [Name("Function")]
    public delegate void EventHandler(object sender, EventArgs e);

    /// <summary>
    /// Represents the method that will handle an event.
    /// </summary>
    /// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An System.EventArgs that contains the event data.</param>
    [External]
    [Name("Function")]
    public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
}
