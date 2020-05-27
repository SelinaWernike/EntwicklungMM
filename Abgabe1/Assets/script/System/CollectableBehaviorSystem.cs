using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class CollectableBehaviorSystem : SystemBase
{
  
    // Start is called before the first frame update
    protected override void OnUpdate()
    {
          Quaternion rotateAround = Quaternion.Euler(new float3(0.0f, 10.0f * Time.DeltaTime,0.0f)) ;
         
        Entities.ForEach((ref Rotation rotate ,ref CollectedComponent collectComponent ) => 
        {
          rotate.Value *=  rotateAround;
        }).Schedule();
    }
}
