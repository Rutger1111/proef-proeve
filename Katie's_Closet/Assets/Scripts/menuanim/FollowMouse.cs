using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    private Vector3 mousePosition;

    public Vector3 positon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));


        transform.position = new Vector3(mousePosition.x - positon.x, mousePosition.y - positon.y, -1f);

        
        
    }
}

