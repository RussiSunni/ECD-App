using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestMinimap : MonoBehaviour
{
    public void LoadWildernessSubmap()
    {
        SceneManager.LoadScene("WildernessSubmap");
    }
    public void LoadExercise01()
    {
        SceneManager.LoadScene("Forest001");
    }
    public void LoadExercise02()
    {
        SceneManager.LoadScene("Forest002");
    }
    public void LoadExercise03()
    {
        SceneManager.LoadScene("Forest003");
    }
    public void LoadExercise04()
    {
        SceneManager.LoadScene("Forest004");
    }
    public void LoadExercise05()
    {
        SceneManager.LoadScene("Forest005");
    }
}