using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

namespace V4
{
    public class SimpleLoadMenu : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            // GameControl.SavePreviousSceneName();
            SceneManager.LoadScene("Menu");
        }
    }
}