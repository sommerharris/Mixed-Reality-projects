using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class Controller1 : MonoBehaviour
{
    //timer
    public Text timeCounter;
    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;
    //health
    private int health = 3;
    public Text healthText;

    void Start()
    {

        timeCounter.text = "Time: 00:00.00";
        timerGoing = false;


        BeginTimer();


    }

    void Update()
    {
        healthText.text = "Health: " + health;
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
        health -= 1;
        }

        if (health <= 0)
        {
            Restart();
        }
    }

    public double ReturnTime()
    {
        Debug.Log(timePlaying.TotalSeconds);
        return timePlaying.TotalSeconds;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while(timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
