using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject enemyPlayer;
    // Select Player to start move
    // Generate units from Player Pool
    // Let Player place all units before next Step
    // Player can now Attack (aslong there is a Nation that can attack)
    [SerializeField] private State _currentGameState;
    public State debugState;
    void Start()
    {
        changeGameState(debugState);
    }

    public void changeGameState(State newState)
    {
        _currentGameState = newState;
        foreach (var eventItem in _currentGameState.events)
        {
            eventItem.Invoke();
        }
    }
}
