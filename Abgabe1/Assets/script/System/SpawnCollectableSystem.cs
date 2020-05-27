using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;


public class SpawnCollectableSystem : SystemBase
{
    BeginInitializationEntityCommandBufferSystem m_EntityCommandBufferSystem;
    
    protected override void OnCreate()
    {
       m_EntityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
       
    }
    protected override void OnUpdate()
    {
    EntityCommandBuffer commandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer();
    Unity.Mathematics.Random random = new Unity.Mathematics.Random((uint) new System.Random().Next());
        Entities.ForEach((ref Entity entity ,ref SpawnCollectableComponent spawnComponent ) => 
        {
           for (int i = 0; i < spawnComponent.number; i++) {
               Entity prefabInstance = commandBuffer.Instantiate(spawnComponent.prefabCollectable);

               float3 position = new float3(random.NextFloat(-10.0f,10.0f), 1.5f, random.NextFloat(-10.0f,10.0f));
               Quaternion rotation = Quaternion.Euler(new float3(0.0f, random.NextFloat(0.0f,360.0f),0.0f));
               commandBuffer.AddComponent(prefabInstance, new Translation {Value = position});
               commandBuffer.AddComponent(prefabInstance, new Rotation {Value = rotation });
               commandBuffer.AddComponent(prefabInstance, new CollectedComponent {isCollected = false});
               

           }

        commandBuffer.DestroyEntity(entity);
        }).Schedule();
    }

    
}

