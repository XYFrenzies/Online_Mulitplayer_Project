using UnityEngine.SceneManagement;

public class MainMenu : Menu
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "MainMenuScene")
        {
            overlays[0].SetActive(true);
        }
    }
}
