using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jungle001 : MonoBehaviour
{
    public Image questionImage, fairyImage, menuPanel;
    public RectTransform menuPanelRectTransform;
    private Sprite fairyIncorrect,
                  fairyNeutral,
                  fairyCorrect;
    int questionNumber = 0;
    Text answerText1, answerText2, answerText3, answerText4;
    public float timeRemaining = 0;
    bool timerReady, correctAnswer, finished = false;

    public void FairyMenu()
    {
        if (menuPanel.GetComponent<CanvasGroup>().interactable == false)
        {
            menuPanel.GetComponent<CanvasGroup>().alpha = 1.0f;
            menuPanel.GetComponent<CanvasGroup>().interactable = true;
        }
        else
        {
            menuPanel.GetComponent<CanvasGroup>().alpha = 0.0f;
            menuPanel.GetComponent<CanvasGroup>().interactable = false;
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("WorldMap");
    }
    public void Cancel()
    {
        menuPanel.GetComponent<CanvasGroup>().alpha = 0.0f;
        menuPanel.GetComponent<CanvasGroup>().interactable = false;
    }
}
