using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnits : MonoBehaviour
{
    [SerializeField] private GameObject _sourceNation;
    [SerializeField] private GameObject _targetNation;
    // [SerializeField]
    [SerializeField] private SelectNation _selecter;
    private float bufferTimer = 0.05f;
    private float timer = 0.0f;
    private float resetTimer = 0.5f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && _selecter.getSelectedNation() != null && timer > bufferTimer)
        {
            // Debug.Log(_selecter.getSelectedNation());
            // setSelections();
            timer = 0.0f;
        }
        timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire2"))
        {
            _sourceNation = null;
            _targetNation = null;
        }
    }

    public void setSelections()
    {
        Debug.Log("Select Nation");
        GameObject nextNation = _selecter.getSelectedNation();
        if (_sourceNation == null)
        {
            _sourceNation = nextNation;
            return;
        }
        else if (_sourceNation != nextNation && _targetNation == null)
        {
            _targetNation = nextNation;
            return;
        }
        else if (_targetNation == nextNation && _sourceNation != nextNation)
        {
            _sourceNation = nextNation;
            _targetNation = null;
            return;
        }
        else if (_sourceNation != nextNation)
        {
            _targetNation = nextNation;
        }
    }
}
