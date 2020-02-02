using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolManager : SingletonBase<ToolManager>
{

    protected ToolManager() { }
    private GameObject currentObj;
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
}
