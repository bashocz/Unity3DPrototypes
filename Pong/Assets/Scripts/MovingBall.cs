using UnityEngine;
using System.Collections;

public class MovingBall : MonoBehaviour
{
    private float speed = 300;
    private bool readyToStart;
    private float startTime;

    // Use this for initialization
    void Start()
    {
        StartBall(2);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (readyToStart && (Time.time > startTime))
            ForceBall();
    }

    void StartBall(float delay)
    {
        readyToStart = true;
        startTime = Time.time + delay;
    }

    void ForceBall()
    {
        float angle = Mathf.Sign(Random.Range(-1, 1)) * Mathf.Deg2Rad * Random.Range(20, 45);
        float x = Mathf.Sign(Random.Range(-1, 1)) * Mathf.Cos(angle) * speed;
        float y = Mathf.Sin(angle) * speed;
        rigidbody2D.AddForce(new Vector2(x, y));
        readyToStart = false;
    }
}
