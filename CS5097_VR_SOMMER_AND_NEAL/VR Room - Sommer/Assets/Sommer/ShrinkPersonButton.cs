using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPersonButton : MonoBehaviour
{
    public GameObject room;
    GrowSurroundings script1;
    public GameObject stairs;
    GrowSurroundings script2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShrinkMe()
    {
    //turn script to grow room
    script1 = room.GetComponent<GrowSurroundings>();
    script1.enabled = true;
    script2 = stairs.GetComponent<GrowSurroundings>();
    script2.enabled = true;
    }
}