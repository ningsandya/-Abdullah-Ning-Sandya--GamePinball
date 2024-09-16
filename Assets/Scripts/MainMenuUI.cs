using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button creditButton;
    public Button exitButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

  public void PlayGame()
  {
    SceneManager.LoadScene("Pinball_Game");
  }

  public void CreditButton()
  {
    SceneManager.LoadScene("Credit");
  }

  public void ExitGame()
  {
    Application.Quit();
  }
}
