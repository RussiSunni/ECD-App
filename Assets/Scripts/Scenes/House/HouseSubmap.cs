using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseSubmap : MonoBehaviour
{
    public void LoadWorldMap()
    {
        SceneManager.LoadScene("WorldMap");
    }
    public void LoadBedroomSubStage()
    {
        // SceneManager.LoadScene("Forest001");
    }
    public void LoadBathroomSubStage()
    {
        // SceneManager.LoadScene("Jungle001");
    }
    public void LoadKitchenSubStage()
    {
        //  SceneManager.LoadScene("DesertIntro");
    }
    public void LoadLoungeSubStage()
    {
        //  SceneManager.LoadScene("TundraIntro");
    }
    public void LoadParkSubStage()
    {
        //  SceneManager.LoadScene("SavannahIntro");
    }
}
