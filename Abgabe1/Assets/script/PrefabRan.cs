using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRan : MonoBehaviour
{
    public GameObject myPrefab;
    private float rotate;
    // Start is called before the first frame update
    //Erstellt zufällige Prefabs mit zufälligen Positionen zu und fügt manchen ein Script hinzu
    void Start()
    {
        
        for(int i = 0; i <= Random.Range(1,10); i++) {

       GameObject go = Instantiate(myPrefab,new Vector3(Random.Range(-10.0f,10.0f),1,Random.Range(-10.0f,10.0f)), Quaternion.Euler(0,Random.Range(0,360),0)) as GameObject;
       if(Random.Range(0,4) <= 2.0f) {
       go.AddComponent<humanRot>(); 
       }
        
        
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
