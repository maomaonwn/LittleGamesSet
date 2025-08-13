using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{get;private set;}

    public Texture2D mouseUpCursor;
    public Texture2D mouseDownCursor;

    void Start()
    {
        SetMouseUpCursor();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //设置光标
            SetMouseDownCursor();
            Invoke("SetMouseUpCursor",.2f);
        }
    }

    public void SetMouseUpCursor()=>Cursor.SetCursor(mouseUpCursor , Vector2.zero , CursorMode.Auto);
    public void SetMouseDownCursor()=>Cursor.SetCursor(mouseDownCursor , Vector2.zero , CursorMode.Auto);
}
