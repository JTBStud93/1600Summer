using UnityEngine;
using System.Collections;

public class Birds : Animal {

    //PROPERTIES
    //Feather count
    public int feathers = 100;
    //Beaks
    public float beak = 0.25f;
    //Wings bool for if they work
    public bool wings = true;
    //Color
    public Color featherColor = Color.red;


    //Fly
    //BuildNests
    //Lay Eggs Overides Reproduction
    //Call

    void Start ()
    {
        if (wings && feathers > 0)
        {
            print("Flying");
        }
        else
        {
            print("Bird is Lame.");
        }

        if (beak < 0.1f || beak > 10)
        {
            print("This bird is too small, or too big.");
        }

    } 

}