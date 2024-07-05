using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    void Update()
    {
        transform.position = playerTransform.position;
    }
}
