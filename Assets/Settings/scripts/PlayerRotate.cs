

using UnityEngine;

public class PlayerRotate: MonoBehaviour
{

    // 
    public float rotationSpeed = 900f;

    void Update()
    {
        float rotation = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            rotation = rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rotation = rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }

        transform.Rotate(0, 0, rotation);
    }
}
