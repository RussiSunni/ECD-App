using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TargetDropPanel : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static DraggableBlock d;
    int answerLetterCount;


    void Start()
    {
        answerLetterCount = 3;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    public void OnDrop(PointerEventData eventData)
    {
        d = eventData.pointerDrag.GetComponent<DraggableBlock>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }

        StartCoroutine((FindChildBlock()));
    }

    IEnumerator FindChildBlock()
    {
        yield return new WaitForSeconds(0.1f);

        if (gameObject.name == "Target01")
        {
            if (gameObject.transform.GetChild(0).gameObject.name == "D")
            {
                Wilderness04.answerCounter++;
            }
        }

        else if (gameObject.name == "Target02")
        {
            if (gameObject.transform.GetChild(0).gameObject.name == "O")
            {
                Wilderness04.answerCounter++;
            }
        }

        else if (gameObject.name == "Target03")
        {
            if (gameObject.transform.GetChild(0).gameObject.name == "G")
            {
                Wilderness04.answerCounter++;
            }
        }


        if (Wilderness04.answerCounter == 3)
        {
            var wilderness04Script = GameObject.Find("Code").GetComponent<Wilderness04>();
            wilderness04Script.NextQuestion();


        }

        // Debug.Log(gameObject.transform.GetChild(0).gameObject.name);
    }
}
