using UnityEngine;
using System.Collections;

public class MovingBall : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        rigidbody2D.AddForce(new Vector2(-300, 0));
    }
    
    // Update is called once per frame
    void Update()
    {
    
    }
}
