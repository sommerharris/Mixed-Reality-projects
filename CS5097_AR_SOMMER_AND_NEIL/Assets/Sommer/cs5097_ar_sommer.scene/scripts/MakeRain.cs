using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRain : MonoBehaviour
{
    public GameObject leaves;
    FlowerGrow script1;
    public GameObject petals;
    PetalGrow script2;
    public GameObject snow1;
    public GameObject snow2;
    public GameObject snow3;
    SnowMelt script3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rain()
    {
    //turn on leaf grow script
    script1 = leaves.GetComponent<FlowerGrow>();
    script1.enabled = true;
    //turn on flower grow script
    script2 = petals.GetComponent<PetalGrow>();
    script2.enabled = true;
    //turn on snow melt scripts
    script3 = snow1.GetComponent<SnowMelt>();
    script3.enabled = true;

    script3 = snow2.GetComponent<SnowMelt>();
    script3.enabled = true;

    script3 = snow3.GetComponent<SnowMelt>();
    script3.enabled = true;
    }

}
