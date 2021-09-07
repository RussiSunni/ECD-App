using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void LoadWildernessStage()
    {
        SceneManager.LoadScene("WildernessIntro");
    }
    public void LoadSchoolStage()
    {
        SceneManager.LoadScene("SchoolIntro");
    }
    public void LoadTownStage()
    {
        SceneManager.LoadScene("TownIntro");
    }
    public void LoadHouseStage()
    {
        SceneManager.LoadScene("HouseIntro");
    }
    public void LoadOceanStage()
    {
        SceneManager.LoadScene("OceanIntro");
    }
}
