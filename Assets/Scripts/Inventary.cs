using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Inventary : MonoBehaviour
{
    public Text coins;
    public int Amount = 0;
    
     public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    void Update(){
        if(Amount == 7){   
            LoadScene("Winner");
        }
}
}
