using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrarysAndLists : MonoBehaviour {

    public List<string> players = new List<string>();

    public void ClickHere (string _s)
    {
        players.Add(_s);
    }

    public void RunLoop ()
    {
        foreach (string item in players)
        {
            print(item);
        }
        if (players.Count != 1)
        {
            print("You have " + players.Count + " players.");
        }
        else
        {
            print("You have " + players.Count + " player.");
        }
        
    }
	
}
