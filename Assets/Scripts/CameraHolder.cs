using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
    }
}
