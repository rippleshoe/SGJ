using UnityEngine;
using System.Collections;

public class TurnController : MonoBehaviour {

	public enum TurnStates
    {
        START,
        PLAYERTURN,
        PLAYERPLAY,
        ENEMYTURN,
        ENEMYPLAY,
        LOSE,
        WIN
    }

    private TurnStates currentState;
    SpawnTroops sT;

    void Awake()
    {
         sT = gameObject.GetComponent<SpawnTroops>();
    }
    

    void Start()
    {
        currentState = TurnStates.START;
        

    }

    void Update()
    {
        
        switch (currentState)
        {
            case (TurnStates.START):
                //Setup Game function
                break;
            case (TurnStates.PLAYERTURN):
                //Call Playerturn scripts
                break;
            case (TurnStates.PLAYERPLAY):
                //call play scripts
                break;
            case (TurnStates.ENEMYTURN):
                //ENEMY ACTIONS
                break;
            case (TurnStates.ENEMYPLAY):
                //Play Scripts
                break;
            case (TurnStates.LOSE):
                //lose state
                break;
            case (TurnStates.WIN):
                //win state
                break;            
        }
    }

    

    void OnGUI()
    {
        if(GUILayout.Button("Next State"))
        {
            currentState += 1;

            Debug.Log(currentState);
        }

        if (GUILayout.Button("Spawn Blue"))
        {
            string teamColour = "BlueTroop";
            Vector3 position = new Vector3(0, 0, 0);
            Quaternion rotation = new Quaternion(0, 0, 0, 0);
            sT.TroopSpawn(teamColour, position, rotation);  
        }

        if (GUILayout.Button("Spawn Red"))
        {
            string teamColour = "RedTroop";
            Vector3 position = new Vector3(0, 0, 0);
            Quaternion rotation = new Quaternion(0, 0, 0, 0);
            sT.TroopSpawn(teamColour, position, rotation);
        }
    }
                        
    public static int CountTroops(string tag)
    {
        int troopNumber = 0;

        troopNumber = GameObject.FindGameObjectsWithTag(tag).Length;

        return troopNumber;
    }

}
