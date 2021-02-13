using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSize : MonoBehaviour
{
    public GameObject player;
    private bool isOverSized = false;
    public Button button;
    public Text text;
    private Vector3 overSizeBall = new Vector3(1f, 1f, 1f);

    void Start()
    {
        button.onClick.AddListener(onClick);
        
    }

    public void onClick(){
        if(isOverSized == false){
            changeBallSizelarger();
        }
        else{
            changeBallSizesmaller();
        }
    }

    public void changeBallSizelarger(){
        
        player.transform.localScale += overSizeBall;
        isOverSized = true;
        text.text = "Shrink";
        

    }

    public void changeBallSizesmaller(){
        
        player.transform.localScale -= overSizeBall;
        text.text = "Oversize";
        isOverSized = false;
        

    }
}
