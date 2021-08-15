using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class GrowSurroundings : MonoBehaviour
{
    public float timer = 0f;
    public float growth = 6f;
    public float maximumX = 15f;
    public float maximumY = 15f;
    public float maximumZ = 15f;
    public bool isMaximumSize = false;
    void Start()
    {
        if (isMaximumSize == false)
        {
            StartCoroutine(Grow());
        }
        //added this line in so we can grow and shrink multiple times
        isMaximumSize = false;
    }

    private IEnumerator Grow()
    {
        Vector3 startScale = transform.localScale;
        Vector3 maximumScale = new Vector3(maximumX, maximumY, maximumZ);

        do 
        {
            transform.localScale = Vector3.Lerp(startScale, maximumScale, timer / growth);
            timer += Time.deltaTime;
            yield return null;

        } while(timer < growth);

        isMaximumSize = true;
    }

}
