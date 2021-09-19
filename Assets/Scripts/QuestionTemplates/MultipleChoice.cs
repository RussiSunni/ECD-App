using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace V4
{
    public class MultipleChoice : MonoBehaviour
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
        public static List<Question> questions = new List<Question>();

        void Start()
        {
            questions = JungleQuestionBank.questions;
            //  Debug.Log(questions.Count);

            answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
            answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
            answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
            answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();

            fairyIncorrect = Resources.Load<Sprite>("V4/FairyIncorrect");
            fairyNeutral = Resources.Load<Sprite>("V4/FairyNeutral");
            fairyCorrect = Resources.Load<Sprite>("V4/FairyCorrect");

            timerReady = false;

            Answer1();
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
                SceneManager.LoadScene("Wilderness003");
            }
            else if (questionNumber == 0)
            {
                questionImage.sprite = questions[0].sprite;
                answerText1.text = questions[0].answerOptions[0];
                answerText2.text = questions[0].answerOptions[1];
                answerText3.text = questions[0].answerOptions[2];
                answerText4.text = questions[0].answerOptions[3];

                questionNumber++;
                GameControl.scene1Started = true;
            }
            else
            {
                if (questions[questionNumber - 1].questionName == answerText1.text)
                {
                    correctAnswer = true;
                    SoundManager.playAnswerSound(questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        public void Answer2()
        {
            if (questionNumber != 0)
            {

                if (questions[questionNumber - 1].questionName == answerText2.text)
                {
                    correctAnswer = true;
                    SoundManager.playAnswerSound(questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        public void Answer3()
        {
            if (questionNumber != 0)
            {

                if (questions[questionNumber - 1].questionName == answerText3.text)
                {
                    correctAnswer = true;
                    SoundManager.playAnswerSound(questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        public void Answer4()
        {
            if (questionNumber != 0)
            {
                if (questions[questionNumber - 1].questionName == answerText4.text)
                {
                    correctAnswer = true;
                    SoundManager.playAnswerSound(questions[questionNumber - 1].answerSound);
                }
                else
                {
                    correctAnswer = false;
                }

                timeRemaining = 1;
                timerReady = true;
            }
        }
        void ChangeQuestion()
        {
            if (timerReady == true)
            {
                //  Debug.Log(questionNumber);
                //  Debug.Log(questions.Count);

                if (correctAnswer == true)
                {
                    questions.RemoveAt(questionNumber - 1);
                }

                else if (questionNumber < questions.Count)
                {
                    // questionNumber++;
                    questions.Add(questions[0]);
                    questions.RemoveAt(0);
                }
                else
                    questionNumber = 1;

                if (questions.Count > 0)
                {
                    questionImage.sprite = questions[questionNumber - 1].sprite;
                    answerText1.text = questions[questionNumber - 1].answerOptions[0];
                    answerText2.text = questions[questionNumber - 1].answerOptions[1];
                    answerText3.text = questions[questionNumber - 1].answerOptions[2];
                    answerText4.text = questions[questionNumber - 1].answerOptions[3];
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

        }
    }
}