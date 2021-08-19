using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroButtonText : MonoBehaviour
{

    Text txt;
    public int imgNumberCount;

    public void changeText() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                txt = gameObject.GetComponent<Text>();
                txt.text = "Hurry child, there is much to do. Do not tarry.";
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                SceneManager.LoadScene("Intro2");
                imgNumberCount++;
                imgNumberCount = 0; //Reset it to 0
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}







