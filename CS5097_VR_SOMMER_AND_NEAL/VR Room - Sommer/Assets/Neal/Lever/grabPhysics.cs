using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabPhysics : MonoBehaviour
{
    Vector3 origin;
    Rigidbody rb;
    public bool isGrabbed = false;
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce((origin - transform.position).normalized * 100);
        if (!isGrabbed)
        {
            float step = 100 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, origin, step);
        }
        
    }

    public void TriggerGrabbed()
    {
        isGrabbed = !isGrabbed;
    }
}
