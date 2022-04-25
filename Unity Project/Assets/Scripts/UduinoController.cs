using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO.Ports;
using Random = UnityEngine.Random;
using Uduino;
using UnityEngine.UI;



public class UduinoController : MonoBehaviour
{
    //data inputs from arduino
    public float buttonInp;
    public float waterInp;
    public float lightInp;
    //public string DataReceived

    int playerInp = 0;
    int nextInp;

    //UduinoManager manager;

    public GameObject myObject;

  

    // Start is called before the first frame update
    void Start()
    {
        //recieves all 3 uduino inputs
        UduinoManager.Instance.OnDataReceived += DataReceived;

    }

    void DataReceived(string data, UduinoDevice board)
    {

        //recieve input data from arduino and splits into individual values to be read
        string[] dataSplit = data.Split(',');
        buttonInp = (float.Parse(dataSplit[0]));
        waterInp = (float.Parse(dataSplit[1]));
        lightInp = (float.Parse(dataSplit[2]));
    }



    // Update is called once per frame
    void Update()
    {
       // int nextInp = Random.Range(1, 4);

        //if (nextInp == 1)
        //{
       //     GameObject BottleBlack;
       //     BottleBlack.SetActive(true);
      //  }
      //  else if (nextInp == 2)
      //  {
      //      GameObject SunBlack;
      //      SunBlack.SetActive(true);
      //  }
      //  else if (nextInp == 3)
      //  {
     //       GameObject WateringCanBlack;
     //       WateringCanBlack.SetActive(true);
     //   }


        // creates a number between 1 and 3

        //assigns player input and checks if it matches requested input
        while (playerInp == 0)
        {
            if (buttonInp == 1.0f)
            {
                playerInp = 1;
            }

            else if (waterInp >= 350.0f)
            {
                playerInp = 2;
            }
            else if (lightInp >= 120.0f)
            {
                playerInp = 3;
            }
            else //if player hasnt chosen input yet
            {
                playerInp = 0;
            }
        }


        if (playerInp == nextInp)
        {
            //choice is reset to zero for next iteration of while loop, and +1 is added to player score
            playerInp = 0;


         
            myObject.GetComponent<Score>();
            Score.totalScore += 1;

        }

        else

        {
            //player loses life if input is wrong 
            myObject.GetComponent<PlayerLives>().wrongInput();
        }
    }
}
  

   






