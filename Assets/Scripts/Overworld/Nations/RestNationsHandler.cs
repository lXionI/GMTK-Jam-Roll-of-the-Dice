using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestNationsHandler : MonoBehaviour
{
    public void restAllNations()
    {
        foreach(Transform children in transform)
        {
            NationInfoHandler currentNation = children.GetComponent<NationInfoHandler>();
            if(currentNation != null)
            {
                currentNation.rested();
            }
        }
    }
}
