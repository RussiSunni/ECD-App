using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void LoadWildernessStage()
    {
        SceneManager.LoadScene("WildernessSubmap");
    }
    public void LoadSchoolStage()
    {
        SceneManager.LoadScene("SchoolSubmap");
    }
    public void LoadTownStage()
    {
        SceneManager.LoadScene("TownSubmap");
    }
    public void LoadHouseStage()
    {
        SceneManager.LoadScene("HouseSubmap");
    }
    public void LoadOceanStage()
    {
        SceneManager.LoadScene("OceanSubmap");
    }
}
