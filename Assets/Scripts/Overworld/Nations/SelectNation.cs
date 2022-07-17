using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectNation : MonoBehaviour
{
    public Camera camera;
    public int layerMask;
    public Material playerMat;
    private GameObject _selectedNation;

    void Start()
    {
        layerMask = 1 << layerMask;
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void selectNation()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        _selectedNation = null;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            // Debug.Log(hit.transform);
            _selectedNation = hit.transform.gameObject;
            // For changing mat to player (can be used after battle)
            // hit.transform.gameObject.GetComponent<MeshRenderer>().material = playerMat;
        }
    }

    public GameObject getSelectedNation()
    {
        return _selectedNation;
    }
}
