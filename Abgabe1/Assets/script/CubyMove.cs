using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubyMove : MonoBehaviour
{
    private Vector3 move;
 
    private Quaternion rotate;
    private Vector3 CamMove;
    private float rotationAngle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       rotationAngle += Input.GetAxis("Horizontal") * Time.deltaTime;
       float moveVertical = Input.GetAxis("Vertical");
        rotating();
        move = new Vector3(0,0,moveVertical);
    
        
       transform.Translate(move * Time.deltaTime * 2f); 
    }
    //Rotation des Würfels. Anpassung der Rotation
    private void rotating() {
        Vector3 playerDirection = new Vector3(Mathf.Sin(rotationAngle),0,Mathf.Cos(rotationAngle));
        rotate = Quaternion.LookRotation(playerDirection, Vector3.up);
        transform.rotation = rotate; 
    }

   
}
