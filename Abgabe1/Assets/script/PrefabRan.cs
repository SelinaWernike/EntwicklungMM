using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRan : MonoBehaviour
{
    public Transform myPrefab;
    private float rotate;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i <= Random.Range(1,10); i++) {

       Instantiate(myPrefab,new Vector3(Random.Range(-5.0f,5.0f),1,Random.Range(-5.0f,5.0f)), Quaternion.Euler(0,Random.Range(0,360),0));
        rotate = Random.value;
        
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
