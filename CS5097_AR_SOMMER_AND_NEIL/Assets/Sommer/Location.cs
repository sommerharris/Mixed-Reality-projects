using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
public float longitudeOfCamera;
public float latitudeOfCamera;

    // Start is called before the first frame update
    void Start()
    {
        //Input.location.start();
    }

    // Update is called once per frame
    void Update()
    {
       // UpdateLocation();
        //if location == desired location
        //then enable scene
    }

    private void UpdateLocation()
    {
        if (Input.location.isEnabledByUser)
        {
            longitudeOfCamera = Input.location.lastData.longitude;
            latitudeOfCamera = Input.location.lastData.latitude;
        }
    }
}
