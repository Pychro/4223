using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject player;
    public Dropdown myDropDown;
    
    void FixedUpdate(){
        var ballrenderer = player.GetComponent<Renderer>();
        if(myDropDown.value == 0){
        ballrenderer.material.SetColor("_Color", Color.red);
        }
        if(myDropDown.value == 1){
        ballrenderer.material.SetColor("_Color", Color.blue);
        }
        if(myDropDown.value == 2){
        ballrenderer.material.SetColor("_Color", Color.green);
        }
    }

    
}
