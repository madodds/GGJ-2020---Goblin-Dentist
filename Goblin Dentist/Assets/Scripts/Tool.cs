using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Tool : MonoBehaviour
{
    RaycastHit2D frontMostRayCastHit;
    public string toolName;
    bool select;
    GameObject tool;

    private bool selected = false;

    float zAxis = 2f;
    Vector3 mousePosition;
    Vector2 startPosition;
    Vector2 direction;
    public float moveSpeed = 100f;
    WorldToPixel gameMousePos;
    Rigidbody2D rb;

    public Texture2D toolTexture;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 hotSpot = Vector2.zero;
    Material material;
    Texture texture;
    GameObject currentObj;
    List<GameObject> tools;

    RectTransform rt;
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
        tools = GameObject.FindGameObjectsWithTag("NotActive").ToList();
        foreach(GameObject tool in tools)
        {
            if (currentObj.activeSelf == false &&  tool != this)
            {
                if(tool.activeSelf == false)
                {
                    currentObj.SetActive(true);
                    currentObj.tag = null;
                }
            }
            else
            {
                Debug.Log("Object:" + tool.name + "is Active:" + tool.activeSelf + " And Tag: " + tool.tag);
            }
        }

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
