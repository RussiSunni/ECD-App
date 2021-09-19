using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OceanSubmap : MonoBehaviour
{
    public void LoadWorldMap()
    {
        SceneManager.LoadScene("WorldMap");
    }
    public void LoadBeachSubStage()
    {
        //  SceneManager.LoadScene("WildernessIntro");
    }
    public void LoadVillageSubStage()
    {
        // SceneManager.LoadScene("SchoolIntro");
    }
    public void LoadUnderTheSeaSubStage()
    {
        // SceneManager.LoadScene("TownIntro");
    }
}
