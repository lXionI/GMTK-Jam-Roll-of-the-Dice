using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    RoundStart = 0,
    RoundEnd = 1,
}


[CreateAssetMenu(fileName="StateSO", menuName="EventSystem/State")]
public class State : ScriptableObject
{
    // public GameState gameState;
    public List<GameEventSO> events;
}
