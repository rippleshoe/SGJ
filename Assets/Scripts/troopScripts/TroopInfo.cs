using UnityEngine;
using System.Collections;

public class TroopInfo : MonoBehaviour {

    string relationID;

    public GameObject GameController;

    public GameObject relatedPiece;

    float Health = 100;

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
        gameObject.name = (relationID + "Force");
        relatedPiece = GameObject.Find(relationID);

        BoardPiece BP = relatedPiece.GetComponent<BoardPiece>();
        BP.relatedPiece = this.gameObject;


    }
}

