using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    // This is the user object set by parameter in Unity
    public GameObject wayPoint;
    public object SommerObject; //?
    private Vector3 wayPointPosition;

    // Speed
    public float speed = 0.05f;
    //30 seconds has passed variable
    public Controller1 controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //speed up every 30 seconds
        if (controller.ReturnTime() / 30 == 0) 
        {
            Debug.Log("Everything Works!");
            speed = speed * 2;
        }
        

        wayPointPosition = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
        //Here, the zombie's will follow the waypoint.
        this.gameObject.transform.position = Vector3.MoveTowards(transform.position, wayPointPosition, speed * Time.deltaTime);

        //if touches, disappear and inform boss
        //SommerObject.cubetouch();
    }
}