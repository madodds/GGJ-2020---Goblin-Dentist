using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ToolSet : MonoBehaviour
{
    GameObject leftClickedObject;
    GameObject rightClickedObject;
    RaycastHit2D frontMostRayCastHit;
    SpriteRenderer spriteRenderer;
    public string toolName;
    bool select;

    float zAxis = 2f;
    Vector3 mousePosition;
    private bool empty = true;
    Vector3 startPosition;
    public float moveSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            select = true;
            SelectObject(select);
            //mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            //transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            
        }
        if (Input.GetMouseButtonDown(1))
        {
            select = false;
            SelectObject(select);
        }
        if(gameObject.name == toolName)
        {
            //WorldUnitsInCamera.y = Camera.GetComponent<Camera>().orthographicSize * 2;
            mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            mousePosition.x = mousePosition.x / Screen.width * WorldUnitin;
            mousePosition.y = mousePosition.y / Screen.height;
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

        }
        else
        {
            transform.position = startPosition;
        }
        //mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePosition.z = zAxis;
        //If you get an error with the above line, replace it with this:
        //mousePosition = new Vector3(mousePosition.x, mousePosition.y, zAxis);

    }
    bool SelectObject(bool select)
    {
        Vector3 clickPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        List<RaycastHit2D> hits = Physics2D.LinecastAll(clickPostion, clickPostion).ToList();
        if (select)
        {
            if (hits.Count() != 0)
            {
                toolName = hits[0].collider.gameObject.name;
                empty = false;
                Cursor.visible = false;
                Debug.Log("Clicked on object" + toolName );
                return true;               
            }
            else
            {
                return false;
            }
        }
        else
        {
            toolName = null;
            empty = true;
            Cursor.visible = true;
           
            return true;
        }
    }
}
