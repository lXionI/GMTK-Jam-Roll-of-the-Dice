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

    public void Register(GameEventListener gameEventListener)
    {
        _listeners.Add(gameEventListener);
    }
    public void Deregister(GameEventListener gameEventListener) => _listeners.Remove(gameEventListener);
}
