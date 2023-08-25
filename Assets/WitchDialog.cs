using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WitchDialog : MonoBehaviour
{
    public GameObject dialogBox;
    public Text message;
    private bool showing = false;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && showing == true) {
            SceneManager.LoadScene("MagicShop");
        }
    }

    public void ShowDialog() {
        dialogBox.SetActive(true);
        showing = true;
        
        message.text = "Hey, my grandma said you can take what you need to keep your grandma from exploding or whatever";
    }
}
