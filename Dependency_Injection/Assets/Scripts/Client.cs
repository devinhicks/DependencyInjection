using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Bike controlled by the player
        public Bike m_PlayerBike;

        // Bike controlled by an android (AI)
        public Bike m_AndroidBike;

        // Bike controlled by a pigeon
        public Bike m_PigeonBike;

        // Bike controlled by a goo ball
        public Bike m_GooBallBike;

        public void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();

            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();

            // Set up a bike with an AI driver and a nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();

            m_AndroidBike.SetEngine(nitroEngine);
            m_AndroidBike.SetDriver(androidDriver);
            m_AndroidBike.StartEngine();

            // Set up a bike with an AI driver and a slime engine
            IEngine slimeEngine = new SlimeEngine();
            IDriver gooBallDriver = new GooBallDriver();

            m_GooBallBike.SetEngine(slimeEngine);
            m_GooBallBike.SetDriver(gooBallDriver);
            m_GooBallBike.StartEngine();

            // Set up a bike with an AI driver and a feather engine
            IEngine featherEngine = new FeatherEngine();
            IDriver pigeonDriver = new PigeonDriver();

            m_PigeonBike.SetEngine(featherEngine);
            m_PigeonBike.SetDriver(pigeonDriver);
            m_PigeonBike.StartEngine();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerBike.TurnLeft();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerBike.TurnRight();
            }
        }

        public void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20),
                "Press A to turn LEFT and D to turn RIGHT");
            GUI.Label(new Rect(10, 30, 500, 20),
                "Output displayed in the debug console");
        }
    }
}
