using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float CurrentSpeed;
    public Vector3 mousePosG;
    Camera cam;
    public Vector2 newPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    void FixedUpdate()
    {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);

        newPosition = Vector2.MoveTowards(transform.position, mousePosG, CurrentSpeed * Time.fixedDeltaTime);

        transform.position = newPosition;
    }
}
