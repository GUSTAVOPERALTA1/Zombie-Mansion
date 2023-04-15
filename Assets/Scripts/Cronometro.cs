using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;
public class Cronometro : MonoBehaviour
{
    [SerializeField] Transform explosionPrefab;
    [SerializeField] GameObject plane;
    // Start is called before the first frame update
    [SerializeField] float StartTime;
    float currentTime;
    public float delayTime = 200f;
    bool timerStarted = false;
    [SerializeField] TMP_Text timerText;
    void Start()
    {
        currentTime = StartTime;
        timerText.text = currentTime.ToString();
        timerStarted = true;  
        plane = GameObject.FindGameObjectWithTag("Plane");
    }
    
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStarted)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                timerStarted = false;
                currentTime = 0;
                Debug.Log("Timer ha llegado a cero");
                LoadScene("GameOver");

            }
            
            timerText.text = "Time : " + currentTime.ToString("f1");
            
        }
}
}
