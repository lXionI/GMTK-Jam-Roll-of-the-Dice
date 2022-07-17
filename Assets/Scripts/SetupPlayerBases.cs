using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPlayerBases : MonoBehaviour
{
    public List<GameObject> _startBases;

    public void instantiatePlayers(GameStateMeta _gameMeta)
    {
        // _players = _gameMeta.getPlayerList();
        foreach (GameObject player in _gameMeta.getPlayerList())
        {
            Instantiate(player, player.transform.position, Quaternion.identity);
            player.GetComponent<playerInfoHolder>()._playerInfo._startNation = _startBases[0];
            _startBases.RemoveAt(0);
        }
    }
}
