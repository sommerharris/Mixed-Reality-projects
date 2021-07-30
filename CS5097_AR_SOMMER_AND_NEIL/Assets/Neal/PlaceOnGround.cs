using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceOnGround : MonoBehaviour
{

    private Pose PlacementPose;
    private ARRaycastManager aRRaycastManager;
    private bool placementPoseIsValid = false;
    public Vector3 position;
    private bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            updateLocation();
        }
           
    }

    private void updateLocation()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        aRRaycastManager.Raycast(screenCenter, hits, TrackableType.Planes);


        placementPoseIsValid = hits.Count > 0;
        // Debug.Log(placementPoseIsValid);
        if (placementPoseIsValid)
        {
            PlacementPose = hits[0].pose;
            active = false;
            position = PlacementPose.position;

            // Debug.Log(gameObject.name);
            // gameObject.transform.SetPositionAndRotation(PlacementPose.position, PlacementPose.rotation);
            Transform transform = GetComponent<Transform>();
            gameObject.transform.position = new Vector3(PlacementPose.position.x, PlacementPose.position.y, PlacementPose.position.z);
        }


    }
}
