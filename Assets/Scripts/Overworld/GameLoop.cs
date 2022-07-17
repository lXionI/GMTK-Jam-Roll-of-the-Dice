using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameLoop : MonoBehaviour
{
    [System.Serializable]
    class GameMetaEvent : UnityEvent <GameStateMeta> {}
    [SerializeField]
    private GameObject _player;
    [SerializeField]
    private GameObject _enemyPlayer;
    [SerializeField]
    private List<GameObject> _players;
    // Select Player to start move
    // Generate units from Player Pool
    // Let Player place all units before next Step
    // Player can now Attack (aslong there is a Nation that can attack)
    [SerializeField] private State _currentGameState;
    [SerializeField] private GameStateMeta _gameMeta;
    public State debugState;
    [SerializeField] private GameEventSO _initGameState;
    [SerializeField] private GameMetaEvent _setupPlayer;
    void Awake()
    {
        changeGameState(debugState);
        // Instantiate Player and AI
        // instantiatePlayers();
        _setupPlayer?.Invoke(_gameMeta);
        _initGameState?.Invoke();
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
