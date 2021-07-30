using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class locationToUI : MonoBehaviour

{
    public Text coordinatesText;

    // Update is called once per frame
    void Update()
    {
        coordinatesText.text = springtime_location.Location.latitude.ToString() + springtime_location.Location.longitude.ToString();
    }
}
