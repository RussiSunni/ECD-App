using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapFairy : MonoBehaviour
{
    public Image menuPanel;
    public RectTransform menuPanelRectTransform;
    void OnMouseDown()
    {
        if (menuPanel.GetComponent<CanvasGroup>().interactable == false)
        {
            menuPanel.GetComponent<CanvasGroup>().alpha = 1.0f;
            menuPanel.GetComponent<CanvasGroup>().interactable = true;
            menuPanelRectTransform.SetAsLastSibling();
        }
        else
        {
            menuPanel.GetComponent<CanvasGroup>().alpha = 0.0f;
            menuPanel.GetComponent<CanvasGroup>().interactable = false;
            menuPanelRectTransform.SetAsFirstSibling();
        }
    }
}
