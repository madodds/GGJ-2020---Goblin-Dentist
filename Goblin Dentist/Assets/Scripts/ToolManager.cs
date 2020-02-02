using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolManager : SingletonBase<ToolManager>
{

    protected ToolManager() { }
    private GameObject currentObj;
    private string repairType;
    public GameObject getInActive()
    {
        return currentObj;
    }
    public void setInActive(GameObject newObject)
    {
        if (currentObj)
        {
            currentObj.SetActive(true);
        }
        currentObj = newObject;
        currentObj.SetActive(false);
    }
    public string getrepairType()
    {
        return repairType;
    }
    public void setrepairMode(string repairMode)
    {
        repairType = repairMode;
    }
}
