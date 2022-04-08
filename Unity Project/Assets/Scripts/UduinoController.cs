using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
using UnityEngine.UI;


public class UduinoController : MonoBehaviour
{

    public bool light = false;
    public bool water = false;
    public bool button = false;

    UduinoManager manager;

    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        manager = UduinoManager.Instance;
        manager.pinMode(AnalogPin.A0, PinMode.Input);

        //gets inputs from the arduino and sends them to uduino to be used
        UduinoManager.Instance.pinMode(6, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(7, PinMode.Input_pullup);
    }

    // Update is called once per frame
    void Update()
    {
        //button
        int buttonInput = UduinoManager.Instance.digitalRead(6);

        if (buttonInput == 0)
        {
            myObject.GetComponent<PlayerLives>().wrongInput();
        }
        else
        {
            myObject.GetComponent<FlowerState>().ChangePlantStage();
        }

        //light
        int analogueValue = manager.analogRead(AnalogPin.A0);
        if (analogueValue < 100)
        {
            myObject.GetComponent<PlayerLives>().wrongInput();
        }
        else if (analogueValue > 100)
        {
            myObject.GetComponent<FlowerState>().ChangePlantStage();
        }

        //water
        int waterLevelInput = UduinoManager.Instance.digitalRead(7);

        if (waterLevelInput < 300)
        {
            myObject.GetComponent<PlayerLives>().wrongInput();
        }
        else
        {
            myObject.GetComponent<FlowerState>().ChangePlantStage();
        }
    }
}
