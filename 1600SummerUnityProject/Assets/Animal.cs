using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

    //PROPERTIES (things they are or have)
    //BodySegments
    public string[] bodySegments = { "Head", "Abs", "Thorax" };
    public string animalName = "Jenny";
    //Health
    public int health = 100;
    //Speed
    public float speed = 0.0f;
    //Size
    public string size;
    public bool canEat;

    public Color baseColor;

    //FUNCTIONS (things they do)
    //Breathe
    public string animalLungs = "Oxygen";
    public bool canBreathe = false;
    //Reproduce
    //Eat
    //Move
    //Die
    //Grow
    void Start ()
    {
        if (!canEat)
        {
            print(this.name + " can eat.");
        }
        else
        {
            print(this.name + " can't eat.");
        }

        if (2 + 5 == 7)
        {
            print(7);
        }

        if (animalName != "Jen")
        {
            print(animalName);
        }

        if (4 + 4 == 8)
        {
            print(8);
        }

        if (animalLungs == "Oxygen")
        {
            print("Oxygen");
        }

        if (speed > 0f)
        {
            speed %= 2f;
        }

        if (health > 0)
        {
            health %= 2;
            print(health);
        }
        else
        {
            Debug.LogError("You can't Divide by Zer0.");
        }
        
    }

}
