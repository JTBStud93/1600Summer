using UnityEngine;
using System.Collections;

public class Mammal : Animal {

    //PROPERTIES
    //Hair
    public bool hasHair = true;
    public int hairCount = 1000;
    public Color hairColor = Color.grey;

    //ArmLength
    public bool ArmLength = true;
    //LegLength
    public int LegLength = 5;
    //NeckLength
    public int NeckLength = 2;

    //Warm Blooded
    //HowManyLegs {1, 2, 4}
    public int legCount = 1;

    //FUNCTIONS
    //Live Birth Overides Reproduction
    //Feed Milk
    //BITE
    
    void Start ()
    {
        if(!hasHair || hairCount < 20)
        {
            print("Hairless.");
        }

        if (!ArmLength && LegLength != 5)
        {
            print("Both Arm & Leg Length are the same.");
        }

        if (!(!ArmLength && NeckLength != 2))
        {
            print("Arm Length is not the same as Neck Length.");
        }
    } 
}

/*
 
    if (!(ArmLength && LegLength))
        {
            print("ArmLength is greater than or equal to LegLength.");
        }

        if (!(ArmLength && NeckLength)
        {
            print("ArmLength is less than or equal to NeckLength.");
        }
        else
        {
            print("ArmLength is greater than NeckLenght");
        }
     */
