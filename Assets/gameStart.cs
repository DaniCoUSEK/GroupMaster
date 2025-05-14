using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{
    public PlayerManager playerManager;
    public GameObject button, button2;
    public void StartGame()
    {
        playerManager.gameState = true;
        button.gameObject.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if(playerManager.FinishLine == true &&  playerManager.gameState == false)
        {
            button2.gameObject.SetActive(true);
        }
        if(playerManager.numberOfStickmans <= 0)
        {
            playerManager.gameState = false;
            playerManager.FinishLine = true;
        }
    }
}
