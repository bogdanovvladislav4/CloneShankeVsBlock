using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameOverMenu : MonoBehaviour
{
    public Game game;
    public void ButtonRestartPressed()
    {
        game.isButtonRestartCliked = true;
    }

    public void ButtonMainMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
