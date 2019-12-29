using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    public void Menu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void openMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void openMarker()
    {
        SceneManager.LoadScene("Marker");
    }

    public void openARCamera()
    {
        SceneManager.LoadScene("ARCamera");
    }
    public void openOrgans()
    {
        SceneManager.LoadScene("Organs");
    }
    public void openheart()
    {
        SceneManager.LoadScene("heart");
    }
    public void openintestine()
    {
        SceneManager.LoadScene("intestine");
    }
    public void openkidneys()
    {
        SceneManager.LoadScene("kidneys");
    }
    public void openlargeintestine()
    {
        SceneManager.LoadScene("large-intestine");
    }
    public void openliver()
    {
        SceneManager.LoadScene("liver");
    }
    public void openlungs()
    {
        SceneManager.LoadScene("lungs");
    }
    public void openspleen()
    {
        SceneManager.LoadScene("spleen");
    }
    public void openstomach()
    {
        SceneManager.LoadScene("stomach");
    }
    public void openpancreas()
    {
        SceneManager.LoadScene("pancreas");
    }
    public void openARVideo()
    {
        SceneManager.LoadScene("ARVideo");
    }
    public void openFeedback()
    {
        SceneManager.LoadScene("Feedback");
    }


    public void Exitt()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
