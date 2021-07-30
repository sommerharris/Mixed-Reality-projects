using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class springtime_location : MonoBehaviour
{

    public float latitude;
    public float longitude;

    public static springtime_location Location { set; get; }

    // Start is called before the first frame update
    void Start()
    {
        Location = this;
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
    public float distance(float latitude, float longitude)
    {
        float r = 6378137;
        float lat1 = this.latitude * Mathf.PI / 180;
        float lat2 = latitude * Mathf.PI / 180;
        float dlat = (latitude - this.latitude) * Mathf.PI / 180;
        float dlong = (longitude - this.longitude) * Mathf.PI / 180;
        float a = Mathf.Sin(dlat / 2) * Mathf.Sin(dlat / 2) +
            Mathf.Sin(dlong / 2) * Mathf.Sin(dlong / 2) * Mathf.Cos(lat1) * Mathf.Cos(lat2);
        float C = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        return r * C;
    }
}