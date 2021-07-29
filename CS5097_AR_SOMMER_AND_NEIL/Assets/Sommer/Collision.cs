using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject cubePrefab;

    public Controller1 controller;

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
        //Destroy(other.gameObject);

        controller.TakeDamage();
        ReSpawnCube(other.gameObject);
    }

    private void ReSpawnCube(GameObject cube)
    {
        Transform playerTransform = this.gameObject.transform;

        float xPos = Random.Range(-2.4f, 3.4f);
        float zPos = Random.Range(3, 8);
        Vector3 newPosition = new Vector3(xPos, .05f, zPos);

        cube.transform.position = newPosition;
    }
}