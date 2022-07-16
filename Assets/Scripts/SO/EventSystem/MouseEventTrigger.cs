using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEventTrigger : MonoBehaviour
{
    public List<GameEventSO> _eventsToFire;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            foreach (var eventItem in _eventsToFire)
            {
                eventItem.Invoke();
            }
        }
    }
}
