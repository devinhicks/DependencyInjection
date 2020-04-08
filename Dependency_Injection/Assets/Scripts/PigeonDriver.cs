using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("A pigeon (AI) will control the bike");
    }
}
