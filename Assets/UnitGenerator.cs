using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitGenerator : MonoBehaviour
{
    public void generateUnit(BaseSetupSO baseSetup)
    {
        GameObject targetNation = baseSetup.baseRef;
        GameObject player = baseSetup.playerRef;
        if (targetNation.GetComponent<NationInfoHandler>() == null)
            return;
        if (player.GetComponent<UnitList>() == null)
            return;

        foreach(var unit in player.GetComponent<UnitList>().units)
            targetNation.GetComponent<NationInfoHandler>().addUnits(unit);
    }
}
