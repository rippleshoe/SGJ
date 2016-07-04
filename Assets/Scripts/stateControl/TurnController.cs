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

    void start()
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
    }

}
