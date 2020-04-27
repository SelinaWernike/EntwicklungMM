using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubyAttack : MonoBehaviour
{
    private int killCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//Zerstoert Objekte mit dem Tag "Destroyable" und zählt die zerstörten Objekte
private void OnCollisionEnter(Collision other) {
    if(other.gameObject.tag == "Destroyable") {
    Destroy(other.gameObject);
    killCount++;
    Debug.Log("Besiegt: " + killCount);
    }
}
}
