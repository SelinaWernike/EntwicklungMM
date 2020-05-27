using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform myFollow;
    private Quaternion startPosition;
    private Quaternion endPosition;
     private Vector3 offsetVector = new Vector3(0,1f,-5f);
     private Vector3 fixedCamera;
     private Quaternion fixedAngle;
     private bool followPlayer = false;
     private float t = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Drueke F um die Kameraperspektive zu aendern");
        fixedCamera = transform.position;
        fixedAngle = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //Druecke F um Kameraperspektive zu wechseln
       /* if(Input.GetKeyDown(KeyCode.F)) {
            followPlayer = !followPlayer;
        } */
        if(followPlayer) {

        startPosition = transform.rotation;
        endPosition = myFollow.rotation;
        
        //Slerp Funktion
        transform.rotation = Quaternion.Slerp(startPosition,endPosition,t);
        Vector3 offsetRotation = myFollow.rotation * offsetVector;
        transform.position = myFollow.position + offsetRotation;
        } else {
            transform.position = fixedCamera;
            transform.rotation = fixedAngle;
        }
    }
}
