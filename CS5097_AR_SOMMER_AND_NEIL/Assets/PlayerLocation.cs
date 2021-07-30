using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using System;

public class PlayerLocation : MonoBehaviour
{
    public double latitude;
    public double longitude;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetLocation());
    }

    // Update is called once per frame
    void Update()
    {
        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
    }

    private IEnumerator GetLocation()
    {

        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
        {
            Permission.RequestUserPermission(Permission.FineLocation);
            Permission.RequestUserPermission(Permission.CoarseLocation);
        }

        if (!Input.location.isEnabledByUser)
            yield return new WaitForSeconds(5);

        Input.location.Start();
        while (Input.location.status == LocationServiceStatus.Initializing)
        {
            yield return new WaitForSeconds(0.5f);
        }

        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
        yield break;
    }

    // return distance between player location and given location in metre.
    public double distance(double latitude, double longitude)
    {
        double r = 6378137;
        double lat1 = this.latitude * Math.PI / 180;
        double lat2 = latitude * Math.PI / 180;
        double dlat = (latitude - this.latitude) * Math.PI / 180;
        double dlong = (longitude - this.longitude) * Math.PI / 180;
        double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
            Math.Sin(dlong / 2) * Math.Sin(dlong / 2) * Math.Cos(lat1) * Math.Cos(lat2);
        double C = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return r * C;
    }
}
