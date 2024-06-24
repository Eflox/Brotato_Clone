/*
 * EventManager.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 11/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;
using System.Collections.Generic;

public static class EventManager
{
    private static Dictionary<Enum, Delegate> _eventDictionary = new Dictionary<Enum, Delegate>();

    public static void ClearEvents()
    {
        _eventDictionary.Clear();
    }

    // Subscribe to an event without parameters
    public static void Subscribe(Enum eventType, Action listener)
    {
        if (_eventDictionary.TryGetValue(eventType, out Delegate thisEvent))
            _eventDictionary[eventType] = Delegate.Combine(thisEvent, listener);
        else
            _eventDictionary[eventType] = listener;
    }

    // Unsubscribe from an event without parameters
    public static void Unsubscribe(Enum eventType, Action listener)
    {
        if (_eventDictionary.TryGetValue(eventType, out Delegate thisEvent))
            _eventDictionary[eventType] = Delegate.Remove(thisEvent, listener);
    }

    // Subscribe to an event with parameters
    public static void Subscribe<T>(Enum eventType, Action<T> listener)
    {
        if (_eventDictionary.TryGetValue(eventType, out Delegate thisEvent))
            _eventDictionary[eventType] = Delegate.Combine(thisEvent, listener);
        else
            _eventDictionary[eventType] = listener;
    }

    // Unsubscribe from an event with parameters
    public static void Unsubscribe<T>(Enum eventType, Action<T> listener)
    {
        if (_eventDictionary.TryGetValue(eventType, out Delegate thisEvent))
            _eventDictionary[eventType] = Delegate.Remove(thisEvent, listener);
    }

    // Trigger an event without parameters
    public static void TriggerEvent(Enum eventType)
    {
        if (_eventDictionary.TryGetValue(eventType, out Delegate thisEvent))
            if (thisEvent is Action callback)
                callback.Invoke();
    }

    // Trigger an event with parameters
    public static void TriggerEvent<T>(Enum eventType, T parameter)
    {
        if (_eventDictionary.TryGetValue(eventType, out Delegate thisEvent))
            if (thisEvent is Action<T> callback)
                callback.Invoke(parameter);
    }
}