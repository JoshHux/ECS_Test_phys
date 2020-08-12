using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Physics;
using Unity.Physics.Systems;
using Unity.Mathematics;
public class PhysicsMoveSystem : JobComponentSystem
{

    protected override JobHandle OnUpdate(JobHandle jobDeps)
    {
        float deltaTime = Time.fixedDeltaTime;

        float curInput = Input.GetAxis("Horizontal");

        Entities.ForEach((ref PhysicsVelocity vel, in PhysicsMoveData moveData) =>
        {
            float3 newVel = vel.Linear;

            if (curInput != 0)
            {
                if (Mathf.Abs(newVel.x + curInput * moveData.moveSpeed) >= moveData.maxSpeed)
                {
                    newVel.x = curInput * moveData.maxSpeed;
                }
                else
                {
                    newVel.x += curInput * moveData.moveSpeed;
                }
            }

            newVel.y = moveData.weight * -10;

            vel.Linear = newVel;

        }).Run();

        return default;
    }

    private float ApplyGravity(PhysicsMoveData data)
    {
        return data.weight * -10;
    }

}
