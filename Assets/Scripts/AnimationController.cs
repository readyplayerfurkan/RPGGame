using UnityEngine;
using UnityEngine.AI;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator characterAnimator;
    [SerializeField] private NavMeshAgent agent;
    private float localZVelocity;

    void Update()
    {
        localZVelocity = transform.InverseTransformDirection(agent.velocity).z;
        characterAnimator.SetFloat("forwardSpeed", localZVelocity);
    }
}
