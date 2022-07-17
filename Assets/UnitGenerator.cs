using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitGenerator : MonoBehaviour
{
    public void generateUnit(GameStateMeta gameMeta)
    {
        GameObject player = gameMeta.getCurrentPlayer();
        GameObject targetNation = player.GetComponent<playerInfoHolder>()._playerInfo._startNation;
        if (targetNation.GetComponent<NationInfoHandler>() == null)
            return;
        if (player.GetComponent<UnitList>() == null)
            return;

        for (int i = 0; i < player.GetComponent<playerInfoHolder>()._playerInfo._unitsPetTurn; i++)
            targetNation.GetComponent<NationInfoHandler>().addUnits(player.GetComponent<UnitList>().getRandomUnit());
    }

    public void generateUnitExceptFirstPlayer(GameStateMeta gameMeta)
    {
        GameObject ignorePlayer = gameMeta.getPlayerList()[0];
        foreach (var player in gameMeta.getPlayerList())
        {
            if(ignorePlayer == player)
                continue;
            GameObject targetNation = player.GetComponent<playerInfoHolder>()._playerInfo._startNation;
            if (targetNation.GetComponent<NationInfoHandler>() == null)
                return;
            if (player.GetComponent<UnitList>() == null)
                return;

            for (int i = 0; i < player.GetComponent<playerInfoHolder>()._playerInfo._unitsPetTurn; i++)
                targetNation.GetComponent<NationInfoHandler>().addUnits(player.GetComponent<UnitList>().getRandomUnit());
        }
    }
}
