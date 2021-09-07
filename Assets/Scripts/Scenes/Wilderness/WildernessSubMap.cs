using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WildernessSubMap : MonoBehaviour
{
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
        SceneManager.LoadScene("DesertIntro");
    }
    public void LoadTundraSubStage()
    {
        SceneManager.LoadScene("TundraIntro");
    }
    public void LoadSavannahSubStage()
    {
        SceneManager.LoadScene("SavannahIntro");
    }
}
