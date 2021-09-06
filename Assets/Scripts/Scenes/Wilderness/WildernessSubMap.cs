using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WildernessSubMap : MonoBehaviour
{
    public void LoadForestSubStage()
    {
        SceneManager.LoadScene("WildernessIntro");
    }
    public void LoadJungleSubStage()
    {
        SceneManager.LoadScene("SchoolIntro");
    }
    public void LoadDesertSubStage()
    {
        SceneManager.LoadScene("TownIntro");
    }
    public void LoadTundraSubStage()
    {
        SceneManager.LoadScene("HouseIntro");
    }
    public void LoadSavannahSubStage()
    {
        SceneManager.LoadScene("OceanIntro");
    }
}
