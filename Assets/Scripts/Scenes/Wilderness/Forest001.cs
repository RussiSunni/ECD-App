using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace V4
{
    public class Forest001 : MonoBehaviour
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

        void Start()
        {
            answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
            answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
            answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
            answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();
            fairyImage = GameObject.Find("Fairy").GetComponent<Image>();

            fairyIncorrect = Resources.Load<Sprite>("V4/FairyIncorrect");
            fairyNeutral = Resources.Load<Sprite>("V4/FairyNeutral");
            fairyCorrect = Resources.Load<Sprite>("V4/FairyCorrect");


            timerReady = false;

            // if (!GameControl.scene1Started)
            // {
            //   SoundManager.playScene1Intro();
            //  answerText1.text = "Start";
            //  }
            // else
            Answer1();

            //print(ForestQuestionBank.questions[0].answerOptions[0]);
        }

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

        public void Answer1()
        {
            if (finished)
            {
                SceneManager.LoadScene("WildernessSubmap");
            }
            else if (questionNumber == 0)
            {
                //questionImage.sprite = Resources.Load<Sprite>("Questions/Animals/Bear");
                questionImage.sprite = ForestQuestionBank.questions[0].sprite;
                answerText1.text = ForestQuestionBank.questions[0].answerOptions[0];
                answerText2.text = ForestQuestionBank.questions[0].answerOptions[1];
                answerText3.text = ForestQuestionBank.questions[0].answerOptions[2];
                answerText4.text = ForestQuestionBank.questions[0].answerOptions[3];
                //print(answerText4.text);

                questionNumber++;
                GameControl.scene1Started = true;
            }
            else
            {

                if (ForestQuestionBank.questions[questionNumber - 1].questionName == answerText1.text)
                {
                    correctAnswer = true;
                    MarkAsKnown();
                    SoundManager.playAnswerSound(ForestQuestionBank.questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                    // SoundManager.playIncorrectSound();
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        public void Answer2()
        {
            if (questionNumber != 0)
            {

                if (ForestQuestionBank.questions[questionNumber - 1].questionName == answerText2.text)
                {
                    correctAnswer = true;
                    MarkAsKnown();
                    SoundManager.playAnswerSound(ForestQuestionBank.questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                    //  SoundManager.playIncorrectSound();
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        public void Answer3()
        {
            if (questionNumber != 0)
            {

                if (ForestQuestionBank.questions[questionNumber - 1].questionName == answerText3.text)
                {
                    correctAnswer = true;
                    MarkAsKnown();
                    SoundManager.playAnswerSound(ForestQuestionBank.questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                    //  SoundManager.playIncorrectSound();
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        public void Answer4()
        {
            if (questionNumber != 0)
            {
                if (ForestQuestionBank.questions[questionNumber - 1].questionName == answerText4.text)
                {
                    correctAnswer = true;
                    MarkAsKnown();
                    SoundManager.playAnswerSound(ForestQuestionBank.questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                    // SoundManager.playIncorrectSound();
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        void ChangeQuestion()
        {
            if (timerReady == true)
            {
                //   Debug.Log(questionNumber);
                //   Debug.Log(ForestQuestionBank.questions.Count);

                if (correctAnswer == true)
                {
                    ForestQuestionBank.questions.RemoveAt(questionNumber - 1);
                }

                else if (questionNumber < ForestQuestionBank.questions.Count)
                {
                    // questionNumber++;
                    ForestQuestionBank.questions.Add(ForestQuestionBank.questions[0]);
                    ForestQuestionBank.questions.RemoveAt(0);
                }
                else
                    questionNumber = 1;

                if (ForestQuestionBank.questions.Count > 0)
                {
                    questionImage.sprite = ForestQuestionBank.questions[questionNumber - 1].sprite;
                    answerText1.text = ForestQuestionBank.questions[questionNumber - 1].answerOptions[0];
                    answerText2.text = ForestQuestionBank.questions[questionNumber - 1].answerOptions[1];
                    answerText3.text = ForestQuestionBank.questions[questionNumber - 1].answerOptions[2];
                    answerText4.text = ForestQuestionBank.questions[questionNumber - 1].answerOptions[3];
                }
                else
                {
                    questionImage.sprite = null;
                    answerText1.text = "Next";
                    answerText2.text = null;
                    answerText3.text = null;
                    answerText4.text = null;

                    finished = true;
                }
            }
        }

        public void MarkAsKnown()
        {
            ForestQuestionBank.questions[questionNumber - 1].known = true;

            if (ForestQuestionBank.questions[questionNumber - 1].number == 1)
            {
                GameControl.animalName001known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 2)
            {
                GameControl.animalName002known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 3)
            {
                GameControl.animalName003known = true;
            }
            if (ForestQuestionBank.questions[questionNumber - 1].number == 4)
            {
                GameControl.animalName004known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 5)
            {
                GameControl.animalName005known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 6)
            {
                GameControl.animalName006known = true;
            }
            if (ForestQuestionBank.questions[questionNumber - 1].number == 7)
            {
                GameControl.animalName007known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 8)
            {
                GameControl.animalName008known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 9)
            {
                GameControl.animalName009known = true;
            }
            if (ForestQuestionBank.questions[questionNumber - 1].number == 10)
            {
                GameControl.animalName010known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 11)
            {
                GameControl.animalName011known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 12)
            {
                GameControl.animalName012known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 13)
            {
                GameControl.animalName013known = true;
            }
            if (ForestQuestionBank.questions[questionNumber - 1].number == 14)
            {
                GameControl.animalName014known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 15)
            {
                GameControl.animalName015known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 16)
            {
                GameControl.animalName016known = true;
            }
            if (ForestQuestionBank.questions[questionNumber - 1].number == 17)
            {
                GameControl.animalName017known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 18)
            {
                GameControl.animalName018known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 19)
            {
                GameControl.animalName019known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 20)
            {
                GameControl.animalName020known = true;
            }
            if (ForestQuestionBank.questions[questionNumber - 1].number == 21)
            {
                GameControl.animalName021known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 22)
            {
                GameControl.animalName022known = true;
            }
            else if (ForestQuestionBank.questions[questionNumber - 1].number == 23)
            {
                GameControl.animalName023known = true;
            }
        }

        void Update()
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                if (correctAnswer)
                    fairyImage.sprite = fairyCorrect;
                else
                    fairyImage.sprite = fairyIncorrect;
            }
            else
            {
                fairyImage.sprite = fairyNeutral;
                ChangeQuestion();
                timerReady = false;
            }
            // if (ForestQuestionBank.questions.Count > 0 && questionNumber != 0)
            // {
            //     if (ForestQuestionBank.questions[questionNumber - 1].size == 2)
            //     {
            //         RectTransform questionRT = questionImage.GetComponent(typeof(RectTransform)) as RectTransform;
            //         questionRT.sizeDelta = new Vector2(800, 712);
            //         questionRT.anchoredPosition = new Vector2(400, -356);

            //         RectTransform fairyRT = fairyImage.GetComponent(typeof(RectTransform)) as RectTransform;
            //         fairyRT.sizeDelta = new Vector2(250.7f, 446.4f);
            //         fairyRT.anchoredPosition = new Vector2(274.7f, 223.2f);
            //     }
            //     else if (ForestQuestionBank.questions[questionNumber - 1].size == 1)
            //     {
            //         RectTransform questionRT = questionImage.GetComponent(typeof(RectTransform)) as RectTransform;
            //         questionRT.sizeDelta = new Vector2(400, 712);
            //         questionRT.anchoredPosition = new Vector2(200, -356);

            //         RectTransform fairyRT = fairyImage.GetComponent(typeof(RectTransform)) as RectTransform;
            //         fairyRT.sizeDelta = new Vector2(400f, 712f);
            //         fairyRT.anchoredPosition = new Vector2(200f, 356.1402f);
            //     }
            // }
        }
    }
}