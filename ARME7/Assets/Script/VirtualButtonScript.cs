using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject aa;
    VirtualButtonBehaviour bb;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        aa.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        aa.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        bb = GetComponentInChildren<VirtualButtonBehaviour>();
        bb.RegisterEventHandler(this);
        aa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
