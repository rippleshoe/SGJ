using UnityEngine;
using System.Collections;

public class BoardPiece : MonoBehaviour {

    string relationID;

    public GameObject GameController;

    public GameObject relatedPiece;

    TeamController GC;
    
    void Awake()
    {
        GC = GameController.GetComponent<TeamController>();
    }


    void Start()
    {
        string teamColour = GC.teamColour;
        int LocalID = TurnController.CountTroops(teamColour);
        string LocalTeam = GC.teamColour;
        relationID = (LocalTeam + LocalID.ToString());
        gameObject.name = (relationID);
        string floatID = relationID + "Force";
        
        
    }

}
