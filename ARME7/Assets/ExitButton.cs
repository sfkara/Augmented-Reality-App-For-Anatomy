using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitBtn()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
