using Unity.Entities;

[GenerateAuthoringComponent]
public struct PhysicsMoveData : IComponentData
{
    public float moveSpeed;
    public float maxSpeed;
    public float weight;
}
