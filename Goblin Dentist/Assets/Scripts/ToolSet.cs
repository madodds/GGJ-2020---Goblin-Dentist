using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ToolSet : MonoBehaviour
{
    RaycastHit2D frontMostRayCastHit;
    public string toolName;
    bool select;
    GameObject tool;

    private bool empty = true;

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

    RectTransform rt;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        //if(gameObject.name == toolName)
        //{
        //    mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //    direction = (mousePosition - transform.position).normalized;
        //    rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        //}
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
                
                tool = hits[0].collider.gameObject;
                empty = false;

                
                int width = Mathf.RoundToInt(toolTexture.width * tool.transform.localScale.x);
                int height = Mathf.RoundToInt(toolTexture.height * tool.transform.localScale.y);
                //renderer.material.mainTexture = newTex;
                //TextureScale.Bilinear(newTex, tex.width * 2, tex.height * 2);

                //cursorTexture.Resize(width - 100, height - 100);
                //cursorTexture.Apply();
                Cursor.SetCursor(toolTexture, hotSpot, cursorMode);
                Debug.Log("Clicked on object" + tool.name);

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
