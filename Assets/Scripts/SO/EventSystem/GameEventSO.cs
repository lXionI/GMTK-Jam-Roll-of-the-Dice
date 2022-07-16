using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="eventSO", menuName="EventSystem/Event/eventSO")]
public class GameEventSO : ScriptableObject
{
    private readonly HashSet<GameEventListener> _listeners = new HashSet<GameEventListener>();

    public void Invoke()
    {
        foreach (var eventListener in _listeners)
        {
            eventListener.RaiseEvent();
        }
    }

    public void Register(GameEventListener newListener) => _listeners.Add(newListener);
    public void Deregister(GameEventListener listener) => _listeners.Remove(listener);
}
