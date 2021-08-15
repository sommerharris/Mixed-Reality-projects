using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class ShrinkSurroundings : MonoBehaviour
{
    public float timer = 0f;
    public float growth = 6f;
    public float minimumX = .067f; //change
    public float minimumY = .067f; //change
    public float minimumZ = .067f; //change
    public bool isMinimumSize = false;
    void Start()
    {
        if (isMinimumSize == false)
        {
            StartCoroutine(Shrink());
        }
        //added this line in so we can grow and shrink multiple times
        isMinimumSize = false;
    }

    private IEnumerator Shrink()
    {
        Vector3 startScale = transform.localScale;
        Vector3 minimumScale = new Vector3(minimumX, minimumY, minimumZ);

        do 
        {
            transform.localScale = Vector3.Lerp(startScale, minimumScale, timer / growth);
            timer += Time.deltaTime;
            yield return null;

        } while(timer < growth);

        isMinimumSize = true;
    }

}