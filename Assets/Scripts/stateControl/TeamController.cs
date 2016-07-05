using UnityEngine;
using System.Collections;

public class TeamController : MonoBehaviour {

    //Public Variables
    public int numberofTroops;
    public string teamColour;

    //Troop Array
    public GameObject[] Troops;
    //Latest CHeck Var 
    int LatestCheck;


    //Awake Method
    void Awake()
    {
        LatestCheck = TurnController.CountTroops(teamColour);
    }
    //Update Method
    void Update()
    { 
        Troops = GameObject.FindGameObjectsWithTag(teamColour);
        
    }
}
