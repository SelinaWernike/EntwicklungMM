using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubyMove : MonoBehaviour
{
    private Vector3 move;
 
    private Quaternion rotate;
    private Vector3 CamMove;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotating();
       float moveHorizontal = Input.GetAxis("Horizontal");
       float moveVertical = Input.GetAxis("Vertical");
        move = new Vector3(moveHorizontal,0,moveVertical);
    
        
       transform.Translate(move * Time.deltaTime); 
    }
    //Rotation des Würfels
    private void rotating() {
        float moveCamHorizontal = Input.GetAxis("CamHorizontal");
       float moveCamVertical = Input.GetAxis("CamVertical");
       CamMove = new Vector3(moveCamHorizontal,0,moveCamVertical);
       rotate = Quaternion.LookRotation(CamMove ,Vector3.up);
        transform.rotation = rotate;
    }

   
}
