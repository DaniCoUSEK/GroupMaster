using UnityEngine;

public class CountFollower : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y + 1, playerTransform.position.z);
    }
}
