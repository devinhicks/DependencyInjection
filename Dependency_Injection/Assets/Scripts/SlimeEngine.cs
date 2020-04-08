using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEngine : IEngine
{
    public void StartEngine()
    {
        ActivateSlimeProduction();
        //Debug.Log("Engine started");
    }

    private void ActivateSlimeProduction()
    {
        Debug.Log("The slime is being produced");
    }
}
