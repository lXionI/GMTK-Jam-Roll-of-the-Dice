using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="GameMeta", menuName="Game/GameMeta")]
public class GameStateMeta : ScriptableObject
{
    public List<GameObject> playerList;

    private int currentPlayerTurn = 0;

    public List<GameObject> getPlayerList()
    {
        return playerList;
    }
    public GameObject getCurrentPlayer()
    {
        return playerList[currentPlayerTurn];
    }

    public void nextPlayerTurn()
    {
        currentPlayerTurn += 1 % playerList.Count;
    }
}
