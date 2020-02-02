using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Tool : MonoBehaviour
{
    public string toolName;
    GameObject tool;
    public Texture2D toolTexture;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 hotSpot = Vector2.zero;
    GameObject currentObj;
    List<GameObject> tools;
    // Start is called before the first frame update
    void Start()
    {
        currentObj = gameObject;
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectObject();

            //mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

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
            //Texture2D cursorArrow = Instantiate(toolTexture, Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation, tool.transform.parent );
            //cursorArrow.Resize(width, height);


            //cursorTexture.Resize(width - 100, height - 100);
            //cursorTexture.Apply();
            ToolManager.Instance.setInActive(tool);
            Cursor.SetCursor(this.toolTexture, hotSpot, cursorMode);
            //tool.SetActive(false);
            //tool.tag = "NotActive";
            Debug.Log("Clicked on object" + tool.name + "Tool is" + tool.tag) ;


        }
    }
}
