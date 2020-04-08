using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooBallDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("A goo ball (AI) will control the bike");
    }
}
