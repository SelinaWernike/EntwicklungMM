using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;


public class PlayerBehaviorSystem : SystemBase
{
    
    // Update is called once per frame
    protected override void OnUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical") * Time.DeltaTime;
        float moveHorizontal = Input.GetAxis("Horizontal") * Time.DeltaTime;
        Entities.ForEach((ref Translation trans, ref Rotation rote, ref PlayerComponent playerComponent ) => 
        {
            playerComponent.rotationAngle += moveHorizontal;
            float3 playerDirection = new float3(Mathf.Sin(playerComponent.rotationAngle),0,Mathf.Cos(playerComponent.rotationAngle));
            Quaternion rotate = Quaternion.LookRotation(playerDirection, Vector3.up);
            rote.Value = rotate; 
            trans.Value += (playerDirection * moveVertical * playerComponent.speed);
    
        

        }).Schedule();
    }
}
