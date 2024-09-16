using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainMenu : MonoBehaviour
{
    public Button mainMenu;
    
    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Start()
    {
        mainMenu.onClick.AddListener(BackMainMenu);
    }
}
