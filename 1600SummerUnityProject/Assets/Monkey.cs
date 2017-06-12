using UnityEngine;
using System.Collections;

public class Monkey : Animal
{

    //PROPERTIES
    //VineSwing
    public bool VineSwing = true;
    //TailGrab
    public bool TailGrab = false;
    //FourHands
    public int FourHands = 4;
    //EatsBannanas
    public int EatBannanas = 1000;

    //And, Or, False

    void Start()
    {
        if (!VineSwing && FourHands < 4)
        {
            print("Can't Swing.");
        }

        else
        {
            print("Can Swing");
        }

        if (FourHands < 4 || FourHands > 4)
        {
            print("Monkey has messed up hands.");
        }

        if (!(TailGrab && EatBannanas > 1000))
        {
            print("Monkey Can Eat Bannanas.");
        }

        else
        {
            print("Monkey Can't Eat Bannanas.");
        }
    }
}