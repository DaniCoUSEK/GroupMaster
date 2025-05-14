using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float limitValue;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovPlayer();
        }
    }
    void MovPlayer()
    {
        float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        float finalXPos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);

        playerTransform.localPosition = new Vector3(finalXPos, 0.5f, 0);
    }
}
