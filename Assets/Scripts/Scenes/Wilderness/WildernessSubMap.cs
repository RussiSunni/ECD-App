using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WildernessSubmap : MonoBehaviour
{
    public void LoadWorldMap()
    {
        SceneManager.LoadScene("WorldMap");
    }
    public void LoadForestSubStage()
    {
        SceneManager.LoadScene("Forest001");
    }
    public void LoadJungleSubStage()
    {
        SceneManager.LoadScene("Jungle001");
    }
    public void LoadDesertSubStage()
    {
        SceneManager.LoadScene("Desert001");
    }
    public void ThePoleSubStage()
    {
        SceneManager.LoadScene("ThePole001");
    }
    public void LoadSavannahSubStage()
    {
        SceneManager.LoadScene("Savannah001");
    }
}
