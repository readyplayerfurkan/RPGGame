using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private NavMeshAgent agent;

    void Update()
    {
        agent.destination = targetTransform.position;
    }
}
