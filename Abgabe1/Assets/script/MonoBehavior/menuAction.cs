using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAction : MonoBehaviour
{
    public GameObject menu;
    private bool activ = false; 
   
    // Start is called before the first frame update

    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
           pressReturn();
        }

        if(activ) {
            Time.timeScale = 0;
        } else {
             Time.timeScale = 1.0f;
        }
    }

    public void pressReturn() {
        activ = !activ;
        menu.SetActive(activ);
    }
}
