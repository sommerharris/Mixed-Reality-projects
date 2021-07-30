using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class showText : MonoBehaviour
{
    public PlaceOnGround script;
    public Text txt;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = script.position.x + "\n" + script.position.y + "\n" + script.position.z;
    }
}
