using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{

    public ParticleSystem particleSystem;
    private Vector3 mousePosition;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));


        transform.position = new Vector3(mousePosition.x - 0.2f, mousePosition.y - 0.2f, -1f);

        
        
    }
}

