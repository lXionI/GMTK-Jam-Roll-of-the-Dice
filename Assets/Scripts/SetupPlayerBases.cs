using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPlayerBases : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyPlayer;
    public GameObject playerBase;
    public GameObject enemyBase;
    public BaseSetupSO playerSetup;
    public BaseSetupSO enemySetup;

    void Start()
    {
        // foreach(var unit in player.GetComponent<UnitList>().units)
            // playerBase.GetComponent<NationInfoHandler>().addUnits(unit);
        // foreach(var unit in enemyPlayer.GetComponent<UnitList>().units)
            // enemyBase.GetComponent<NationInfoHandler>().addUnits(unit);
        playerSetup.playerRef = player;
        playerSetup.baseRef = playerBase;
        enemySetup.playerRef = enemyPlayer;
        enemySetup.baseRef = enemyBase;
    }
}
