using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class FlowerGrow : MonoBehaviour
{
    public float timer = 0f;
    public float growth = 6f;
    public float maximumSize = 2f;
    public bool isMaximumSize = false;
    void Start()
    {
        if (isMaximumSize == false)
        {
            StartCoroutine(Grow());
        }
    }

    private IEnumerator Grow()
    {
        Vector3 startScale = transform.localScale;
        Vector3 maximumScale = new Vector3(maximumSize, .1f, maximumSize);

        do 
        {
            transform.localScale = Vector3.Lerp(startScale, maximumScale, timer / growth);
            timer += Time.deltaTime;
            yield return null;

        } while(timer < growth);

        isMaximumSize = true;
    }

}
