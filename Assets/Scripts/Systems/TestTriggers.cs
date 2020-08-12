using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Physics;
using Unity.Physics.Systems;
using Unity.Mathematics;
using Unity.Burst;

/*public class TestTriggers : JobComponentSystem
{
    [BurstCompile]
    //processes the collider that collided witht he trigger
    //ITriggerEventsJob handles trigger collisions
    private struct TriggerJob : ITriggerEventsJob
    {
        //component data from the colliders involved with the trigger's collision
        //is also an array?
        public ComponentDataFromEntity<PhysicsVelocity> physicsVelocityEntities;
        public void Execute(TriggerEvent triggerEvent)
        {
            //if entity A has physics velocity
            if (physicsVelocityEntities.HasComponent(triggerEvent.EntityA))
            {
                //gets the physics velocity component from entitiy A
                PhysicsVelocity physicsVelocity = physicsVelocityEntities[triggerEvent.EntityA];
                physicsVelocity.Linear.y = 5;
                //sets the new velcity to the object
                physicsVelocityEntities[triggerEvent.EntityA] = physicsVelocity;
            }

            //if entity B has physics velocity
            if (physicsVelocityEntities.HasComponent(triggerEvent.EntityB))
            {
                //gets the physics velocity component from entitiy B
                PhysicsVelocity physicsVelocity = physicsVelocityEntities[triggerEvent.EntityB];
                physicsVelocity.Linear.y = 5;
                //sets the new velcity to the object
                physicsVelocityEntities[triggerEvent.EntityB] = physicsVelocity;
            }
            //throw new System.NotImplementedException();
        }
    }

    private BuildPhysicsWorld buildPhysicsWorld;
    private StepPhysicsWorld stepPhysicsWorld;

    protected override void OnCreate()
    {
        buildPhysicsWorld = World.GetOrCreateSystem<BuildPhysicsWorld>();
        stepPhysicsWorld = World.GetOrCreateSystem<StepPhysicsWorld>();
    }

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        TriggerJob triggerJob = new TriggerJob
        {
            physicsVelocityEntities = GetComponentDataFromEntity<PhysicsVelocity>()
        };

        return triggerJob.Schedule(stepPhysicsWorld.Simulation, ref buildPhysicsWorld.PhysicsWorld, inputDeps);
        
        //  throw new System.NotImplementedException();
    }
}*/
