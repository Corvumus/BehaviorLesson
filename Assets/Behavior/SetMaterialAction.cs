using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "SetMaterial", story: "Assign [Material] to [Agent]", category: "Action/Renderer", id: "e9a98c9d0828ba7867d637cfeb1b9a6b")]
public partial class SetMaterialAction : Action
{
    [SerializeReference] public BlackboardVariable<Material> Material;
    [SerializeReference] public BlackboardVariable<GameObject> Agent;

    protected override Status OnStart()
    {
        if (Agent.Value == null || Material.Value == null)
            return Status.Failure;

        if (!Agent.Value.TryGetComponent<Renderer>(out var renderer))
            return Status.Failure;

        renderer.material = Material.Value;
        return Status.Success;
    }
}

