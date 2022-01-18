using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{

    [SerializeField]
    private GameObject _mainManuPanel;

    [SerializeField]
    private GameObject _creditsPanel;
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {

        Application.Quit();
    }

    public void GoToCredits()
    {
        _creditsPanel.SetActive(true);
        _mainManuPanel.SetActive(false);
    }

    public void BackToMenu()
    {
        _creditsPanel.SetActive(false);
        _mainManuPanel.SetActive(true);
    }

}
