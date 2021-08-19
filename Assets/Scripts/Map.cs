using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void LoadFarmStage()
    {
        SceneManager.LoadScene("Farm001");
    }

    public void LoadHouseStage()
    {

    }

    public void LoadSchoolStage()
    {
        SceneManager.LoadScene("SchoolIntro");
    }

    public void LoadWildernessStage()
    {
        SceneManager.LoadScene("WildernessIntro");
    }
    public void LoadTownStage()
    {
        SceneManager.LoadScene("Town001");
    }

}
