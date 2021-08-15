using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPersonButton : MonoBehaviour
{
    public GameObject room;
    ShrinkSurroundings script1;
    public GameObject stairs;
    ShrinkSurroundings script2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrowMe()
    {
    //turn script to shrink room
    script1 = room.GetComponent<ShrinkSurroundings>();
    script1.enabled = true;
    script2 = stairs.GetComponent<ShrinkSurroundings>();
    script2.enabled = true;
    }
}