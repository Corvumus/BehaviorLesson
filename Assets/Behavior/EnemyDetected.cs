using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/EnemyDetected")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "EnemyDetected", message: "[Agent] has spotted [Enemy]", category: "Events", id: "b63a1fa0ea9e157f3d0bdebc1d921732")]
public sealed partial class EnemyDetected : EventChannel<GameObject, GameObject> { }

