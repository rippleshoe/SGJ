using UnityEngine;
using System.Collections;

public class BoardPiece : MonoBehaviour {

    public string pieceID;
    public string relatedTroop;

    public GameObject GameController;

    TeamController GC;
    
    void Awake()
    {
        GC = GameController.GetComponent<TeamController>();
    }


    void Start()
    {
        int LocalID = GC.numberofTroops;
        string LocalTeam = GC.teamColour;

        pieceID = (LocalTeam + LocalID.ToString());
       
    }

}
