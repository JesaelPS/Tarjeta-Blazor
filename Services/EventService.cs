using System.Collections.Generic;
using blazor.Models;

public class EventService
{
    public List<Card> Events { get; private set; } = new List<Card>();

    public void AddEvent(Card newEvent)
    {
        Events.Add(newEvent);
    }

    public IEnumerable<Card> GetEvents()
    {
        return Events;
    }

    public void ClearEvents()
    {
        Events.Clear();
    }
}
