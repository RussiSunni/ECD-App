using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TownSubmap : MonoBehaviour
{
    public void LoadWorldMap()
    {
        SceneManager.LoadScene("WorldMap");
    }
    public void LoadFoodShopSubStage()
    {
        // SceneManager.LoadScene("Forest001");
    }
    public void LoadClothesShopSubStage()
    {
        // SceneManager.LoadScene("Jungle001");
    }
    public void LoadRestaurantSubStage()
    {
        //  SceneManager.LoadScene("DesertIntro");
    }
    public void LoadHospitalSubStage()
    {
        //  SceneManager.LoadScene("TundraIntro");
    }
    public void LoadStreetSubStage()
    {
        //  SceneManager.LoadScene("SavannahIntro");
    }
}
