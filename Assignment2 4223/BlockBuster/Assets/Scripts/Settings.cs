using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Text sliderText;
    public Slider mySlider;
    public GameObject player;

    void start(){
        sliderText = GetComponent<Text>();
        }

    public void changeBallSize(){
        gameObject.GetComponent<Transform>().localScale += new Vector3(mySlider.value, mySlider.value, mySlider.value);
    }

    public void sliderController(float value){
        sliderText.text = mySlider.value + "%";
    }

    public void redBall(int color){
        if(color == 0){
        var ballrenderer = player.GetComponent<Renderer>();
        ballrenderer.material.SetColor("_Color", Color.red);
        }
    }
}
