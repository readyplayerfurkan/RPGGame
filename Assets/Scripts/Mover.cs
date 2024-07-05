using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            MoveToCursor();
    }

    void MoveToCursor()
    {
        Ray lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool isRayHitSomething = Physics.Raycast(lastRay, out hit);

        if (isRayHitSomething)
            agent.destination = hit.point;
    }
}
