using UnityEngine;
using System.Collections;

public class Dog : MammalsWithLegs {

    //PROPERTIES
    //HowManyLegs Overides {4}
    //Smell
    public bool NoseSniffer = true;
    //Rabies
    public int Rabies = 10;
    //BarkNoise
    public float BarkNoise = 2.5f;

    //FUNCTIONS
    //Bark
    //Attack

    void Start()
    {
        if (BarkNoise < 2.4f || BarkNoise > 2.6f)
        {
            print("Too quiet or too loud.");
        }
        else
        {
            print("Not Annoying");
        }

        if (NoseSniffer && Rabies > 1)
        {
            print("Wild Dog.");
        }
        else
        {
            print("Clean Dog.");
        }

    }

}
