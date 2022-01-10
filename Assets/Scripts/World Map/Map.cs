using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void LoadWildernessStage()
    {
        SceneManager.LoadScene("Wilderness001");
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

    public void LoadTempleStage()
    {
        SceneManager.LoadScene("Temple001");
    }
}
