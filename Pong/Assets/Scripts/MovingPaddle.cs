using UnityEngine;
using System.Collections;

public class MovingPaddle : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, speed, 0);
        } else if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -speed, 0);
        }
    }

}
