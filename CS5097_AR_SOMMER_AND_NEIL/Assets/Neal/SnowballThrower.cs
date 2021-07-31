using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballThrower : MonoBehaviour
{
    public GameObject snowball;
    public GameObject camera;
    private float width;
    private float height;
    private float InstantiationTimer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        InstantiationTimer -= Time.deltaTime;
        if (Input.touchCount > 0)
        {
            //Vector2 startPosition = new Vector2(width, height);
            //Vector2 endPosition = new Vector2(width, height);
            //Touch touch = Input.GetTouch(0);
            //if (touch.phase == TouchPhase.Began)
            //{
            //    Vector2 pos = touch.position;
            //    pos.x = (pos.x - width) / width;
            //    pos.y = (pos.y - height) / height;
            //    startPosition = new Vector2(-pos.x, pos.y);
            //}
            //if (touch.phase == TouchPhase.Ended)
            //{
            //    Vector2 pos = touch.position;
            //    pos.x = (pos.x - width) / width;
            //    pos.y = (pos.y - height) / height;
            //    endPosition = new Vector2(-pos.x, pos.y);
            //    float velocity = Vector2.Distance(startPosition, endPosition);
            //    throwSnowball(velocity);
            //}
            
            if (InstantiationTimer <= 0)
            {
                throwSnowball(200);
                InstantiationTimer = 0.5f;
            }
        }
    }

    void throwSnowball(float v)
    {
        Vector3 camPos = camera.transform.position;
        Vector3 camDir = camera.transform.forward;
        Quaternion camRotation = camera.transform.rotation;
        Vector3 spawnPos = camPos + camDir * 0.5f;

        Vector3 force = camDir * v;
        var ball = Instantiate(snowball, spawnPos, camRotation);
        ball.AddComponent<Rigidbody>();
        var ballRB = ball.GetComponent<Rigidbody>();
        ballRB.AddForce(force);
    }
}
