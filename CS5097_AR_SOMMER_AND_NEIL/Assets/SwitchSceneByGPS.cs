using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneByGPS : MonoBehaviour
{
    public PlayerLocation location;
    public string defaultScene = "AR[Main]";
    public double targetLatitude1;
    public double targetLongitude1;
    public string targetSceneName1 = "AR[Sommer]";
    public double targetLatitude2;
    public double targetLongitude2;
    public string targetSceneName2 = "AR[Neal]";
    public double radius = 10;
    public bool active;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            if (location.distance(targetLatitude1, targetLongitude1) <= radius && SceneManager.GetActiveScene().name != targetSceneName1)
            {
                SceneManager.LoadScene(targetSceneName1);
            }
            else if (location.distance(targetLatitude2, targetLongitude2) <= radius && SceneManager.GetActiveScene().name != targetSceneName2)
            {
                SceneManager.LoadScene(targetSceneName2);
            }
            else
            {
                SceneManager.LoadScene(defaultScene);
            }
        }
        
    }

    public void toggle()
    {
        active = !active;
    }
}
