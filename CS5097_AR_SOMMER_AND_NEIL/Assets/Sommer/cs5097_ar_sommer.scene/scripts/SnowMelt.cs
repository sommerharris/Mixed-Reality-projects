using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class SnowMelt : MonoBehaviour
{
    public float timer = 0f;
    public float growth = 6f;
    public float melted = 0f;
    public bool isMelted = false;
    void Start()
    {
        if (isMelted == false)
        {
            StartCoroutine(Grow());
        }
    }

    private IEnumerator Grow()
    {
        Vector3 startScale = transform.localScale;
        Vector3 maximumScale = new Vector3(melted, melted, melted);

        do 
        {
            transform.localScale = Vector3.Lerp(startScale, maximumScale, timer / growth);
            timer += Time.deltaTime;
            yield return null;

        } while(timer < growth);

        isMelted = true;
    }

}
