using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform myFollow;
    private Quaternion startPosition;
    private Quaternion endPosition;
     private Vector3 offsetVector;
     private float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        offsetVector = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        startPosition = transform.rotation;
        endPosition = myFollow.rotation;
        
        //Slerp Funktion
        t += (Time.deltaTime)/5;
        transform.rotation = Quaternion.Slerp(startPosition,endPosition,t);

        if (startPosition.eulerAngles == endPosition.eulerAngles) {
            t = 0;
        }
        //transform.rotation = myFollow.rotation;

        Vector3 offsetRotation = myFollow.rotation * offsetVector;
        transform.position = myFollow.position + offsetRotation;
    }
}
