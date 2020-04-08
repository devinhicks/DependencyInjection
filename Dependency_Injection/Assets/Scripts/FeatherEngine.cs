using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatherEngine : IEngine
{
    public void StartEngine()
    {
        ActivateFlapping();
        //Debug.Log("Engine started");
    }

    private void ActivateFlapping()
    {
        Debug.Log("The flapping is activated");
    }
}
