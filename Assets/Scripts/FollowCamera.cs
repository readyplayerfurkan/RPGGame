using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    void LateUpdate()
    {
        transform.position = playerTransform.position;
    }
}
