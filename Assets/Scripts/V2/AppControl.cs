using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppControl : MonoBehaviour
{
    public Image questionImage;
    public static List<DictionaryLookup> dictionaryLookupsList = new List<DictionaryLookup>();
    public static int answerCounter = 0;

    public Transform target1, target2, target3, target4;
    public Transform DParent, OParent, GParent;
    public Transform D, O, G;

    void Start()
    {
        questionImage.sprite = Resources.Load<Sprite>("V2/VocabImages/DOG");

        DomesticAnimalQuestionBank.LoadQuestionList();

        // questionImage.sprite = DomesticAnimalQuestionBank.domesticAnimalNameQuestions[1].sprite;
    }


    public void NextQuestion()
    {
        D.SetParent(DParent);
        O.SetParent(OParent);
        G.SetParent(GParent);

        questionImage.sprite = Resources.Load<Sprite>("V2/VocabImages/DUCK");

        target1.localPosition = new Vector3(-150.25f, -120, 0);
        target2.localPosition = new Vector3(-49.5f, -120, 0);
        target3.localPosition = new Vector3(49.5f, -120, 0);
        target4.localPosition = new Vector3(150.25f, -120, 0);
        target4.GetComponent<CanvasGroup>().alpha = 1;
    }
}
