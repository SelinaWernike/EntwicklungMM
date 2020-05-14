using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonForward : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject playerObject;

    private float speed = 0f;
    private float rotation = 0f;
    private Quaternion direction;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
       for (int i = 0; i < vbs.Length; i++) {
           vbs[i].RegisterEventHandler(this);
       }
    }

    // Update is called once per frame
    void Update()
    {
       playerObject.transform.Rotate(Vector3.up, rotation * Time.deltaTime);
       playerObject.transform.Translate(new Vector3(0,0,speed) * Time.deltaTime); 
    }

    public void OnButtonPressed (VirtualButtonBehaviour vb) {

        switch (vb.VirtualButtonName)
        {
            case "Forward":
                speed = -2f;
            break;

            case "Backward":
                speed = 2f;
            break;

            case "Left":
                rotation = -10f;
            break;

            case "Right":
                rotation = 10f;
            break;

        }
    }

    public void OnButtonReleased (VirtualButtonBehaviour vb) {
            switch (vb.VirtualButtonName)
        {
            case "Forward":
                speed = 0f;
            break;

            case "Backward":
                speed = 0f;
            break;

            case "Left":
                rotation = 0f;
            break;

            case "Right":
                rotation = 0f;
            break;

        }
    }
}
