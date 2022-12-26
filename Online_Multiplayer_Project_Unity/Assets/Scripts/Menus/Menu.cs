using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UIElements;
public class Menu : MonoBehaviour
{
    [SerializeField]
    private List<Button> menuButtons;

    [SerializeField]
    protected List<GameObject> overlays;

    private int menuID;

    public int MenuID 
    {
        get => menuID;
        private set 
        {
            menuID = value;
        }
    }

    private string menuName;

    public string MenuName 
    {
        get => menuName;
        private set 
        {
            menuName = value;
        }
    }

    private bool menuIsOpen = false;

    public bool MenuIsOpen 
    {
        get => menuIsOpen;
        private set 
        {
            menuIsOpen = value;
        }
    }

    public List<Button> GetAllMenuButtons() 
    {
        return menuButtons;
    }

    public virtual void OnPlayButtonPress(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void OpenMenu(GameObject menu) 
    {
        menuIsOpen = true;
        menu.SetActive(true);
    }

    public virtual void OnChangeMenuPressed(GameObject menuOpened, GameObject menuClosed) 
    {
        menuOpened.SetActive(false);
        menuClosed.SetActive(true);
    }

    public void CloseMenu(GameObject menu) 
    {
        menuIsOpen = false;
        menu.SetActive(false);
    }

    public virtual void OnQuitPress()
    {
        Application.Quit();
    }
}
