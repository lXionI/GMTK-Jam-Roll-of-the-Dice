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
        playerSetup.playerRef = player;
        playerSetup.baseRef = playerBase;
        enemySetup.playerRef = enemyPlayer;
        enemySetup.baseRef = enemyBase;
    }
}
