using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
         button.onClick.AddListener(onClick);
    }

    void onClick(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
