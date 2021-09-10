using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizePlayer : MonoBehaviour
{
    public GameObject player;
    public float scale;
    public bool small = false;

    // Start is called before the first frame update
    void Start()
    {
        resize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resize()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        yield return 0;
        Vector3 newScale = transform.localScale;
        if (small)
        {
            newScale *= scale;
        }
        else
        {
            newScale /= scale;
        }
        small = !small;
        transform.localScale = newScale;
    }
}
