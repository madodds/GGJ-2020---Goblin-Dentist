﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Tool : MonoBehaviour
{
    public string repairMode;
    GameObject tool;
    public Texture2D toolTexture;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 hotSpot = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectObject();
        }
    }

    void Update()
    {

    }
    void SelectObject()
    {
        Vector3 clickPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        List<RaycastHit2D> hits = Physics2D.LinecastAll(clickPostion, clickPostion).ToList();
        if (hits.Count() != 0)
        {
            

            tool = hits[0].collider.gameObject;
            ToolManager.Instance.setInActive(tool);
            ToolManager.Instance.setrepairMode(repairMode);
            Cursor.SetCursor(this.toolTexture, hotSpot, cursorMode);
            Debug.Log("Clicked on object" + tool.name + "Tool is" + tool.tag) ;


        }
    }
}
