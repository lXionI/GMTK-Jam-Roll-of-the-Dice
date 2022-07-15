using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNation : MonoBehaviour
{
    public Camera camera;
    public int layerMask;
    public Material playerMat;

    void Start()
    {
        layerMask = 1 << layerMask;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log(hit.transform);
                // For changing mat to player (can be used after battle)
                // hit.transform.gameObject.GetComponent<MeshRenderer>().material = playerMat;
            }
        }
    }
}
