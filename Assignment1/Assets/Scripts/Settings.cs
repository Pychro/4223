using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Settings : MonoBehaviour
{

    public string name;
    public GameObject inputField;
    public GameObject textDisplay;
    public Slider mySlider;
    public Text sliderText;

    void Start(){
        sliderText = GetComponent<Text>();

    }


    public void menu(){
        SceneManager.LoadScene(0);
    }

    public void level1(){
        SceneManager.LoadScene(1);
    }
    
    public void level2(){
        SceneManager.LoadScene(2);
    }

    public void level3(){
        SceneManager.LoadScene(3);
    }

    public void credits(){
        SceneManager.LoadScene(4);
    }

    public void settingPlayer(){
        name = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = name;
    }

    public void sliderController(float value){
        sliderText.text = mySlider.value + "%";
    }
    
}
