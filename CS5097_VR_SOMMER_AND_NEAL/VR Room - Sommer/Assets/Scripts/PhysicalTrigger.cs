using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalTrigger : MonoBehaviour
{
    public ResizeTrigger trigger;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        trigger.resize();
        StartCoroutine(waitFor2());
    }

    private IEnumerator waitFor2()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(2);
        gameObject.GetComponent<Collider>().enabled = true;

    }
}
