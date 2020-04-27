using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanBehaviour : MonoBehaviour
{
   private float rndmAttribute;
   private float rotation;  
   private Quaternion rotating;
    // Start is called before the first frame update
    void Start()
    {
        rndmAttribute = Random.Range(1,3);
    }

    // Update is called once per frame
    void Update()
    {
        //if(rndmAttribute <= 2.0) {
           transform.Rotate(Vector3.back * Time.deltaTime * 2.0f);
       // } else {

        //}
    }

    void OnCollisionEnter(Collision other) {
        Destroy(this);
    }
}
