using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(onClick);
        
    }

    public void onClick(){
        if(isPaused == false){
            Time.timeScale = 0;
            isPaused = true;
        }
        else{
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
