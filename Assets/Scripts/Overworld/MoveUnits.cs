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

    public void checkCommand()
    {
        if (_sourceNation == null || _targetNation == null)
            return;
        if (_sourceNation.GetComponent<NationInfoHandler>().getOwner() != _targetNation.GetComponent<NationInfoHandler>().getOwner())
        {
            startFightForNation();
            return;
        }
        moveUnits();
        // Check if to fight
        // or to move 
    }

    public void moveUnits()
    {
        if (_sourceNation == null || _targetNation == null)
            return;
        // Check who owns the nation
        NationInfoHandler sourceNationInfo = _sourceNation.GetComponent<NationInfoHandler>();
        NationInfoHandler targetNationInfo = _targetNation.GetComponent<NationInfoHandler>();
        // If dont own => Fight

        foreach (var unit in sourceNationInfo.getUnits())
        {
            targetNationInfo.addUnits(unit);
        }
        sourceNationInfo.removeAllUnits();
        _targetNation.GetComponent<NationInfoHandler>().setOwner(_sourceNation.GetComponent<NationInfoHandler>().getOwner());
    }

    void startFightForNation()
    {
        // TODO: implement real fighting / convert this to an event for starting real auto battle fight
        // Debug Solutions
        int sourceArmySize = _sourceNation.GetComponent<NationInfoHandler>().getUnits().Count;
        int targetArmySize = _targetNation.GetComponent<NationInfoHandler>().getUnits().Count;

        if(sourceArmySize > targetArmySize)
        {
            // Win
            Debug.Log("WE WON BABY");
            if(targetArmySize > 0)
            {
                _sourceNation.GetComponent<NationInfoHandler>().removeUnits(sourceArmySize - targetArmySize);
            }
            _targetNation.GetComponent<NationInfoHandler>().removeAllUnits();
            moveUnits();
        }
        else if (sourceArmySize < targetArmySize)
        {
            // Loose
            _targetNation.GetComponent<NationInfoHandler>().removeUnits(targetArmySize - sourceArmySize);
            _sourceNation.GetComponent<NationInfoHandler>().removeAllUnits();
        }
        else
        {
            // Draw
            _sourceNation.GetComponent<NationInfoHandler>().removeAllUnits();
            _targetNation.GetComponent<NationInfoHandler>().removeAllUnits();
        }
    }
}
