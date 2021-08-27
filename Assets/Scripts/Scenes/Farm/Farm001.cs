using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace V4
{
    public class Farm001 : MonoBehaviour
    {
        void Start()
        {

        }
        public void AnswerButton01()
        {
            SceneManager.LoadScene("Farm002");
        }

    }
}