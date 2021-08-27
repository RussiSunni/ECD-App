using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace V4
{
    public class WildernessIntro : MonoBehaviour
    {
        private float timeRemaining = 2;

        void Update()
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("Wilderness01");
            }
        }
    }
}