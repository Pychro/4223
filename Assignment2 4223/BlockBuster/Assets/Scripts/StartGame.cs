using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
         button.onClick.AddListener(onClick);
    }

    void onClick(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }

}
