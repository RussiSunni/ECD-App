 
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class IntroImage : MonoBehaviour {
 
    public Sprite teacherImg; // I attched these from editor
    public int imgNumberCount;
 
    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {
 
            case 0:
                GetComponent<Image>().sprite = teacherImg;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
        
            case 2:
                imgNumberCount++;
                imgNumberCount = 0; //Reset it to 0
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}
 