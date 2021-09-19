using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchoolSubmap : MonoBehaviour
{
    public void LoadWorldMap()
    {
        SceneManager.LoadScene("WorldMap");
    }
    public void LoadLibrarySubStage()
    {
        //  SceneManager.LoadScene("WildernessIntro");
    }
    public void LoadClassroomSubStage()
    {
        // SceneManager.LoadScene("SchoolIntro");
    }
    public void LoadSportsFieldSubStage()
    {
        // SceneManager.LoadScene("TownIntro");
    }
    public void LoadGymSubStage()
    {
        // SceneManager.LoadScene("HouseIntro");
    }
}
