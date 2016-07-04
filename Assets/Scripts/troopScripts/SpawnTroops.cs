using UnityEngine;
using System.Collections;

public class SpawnTroops : MonoBehaviour
{
    
    public GameObject blue, red;

    
    
    //Method to spawn troop based on team colour
    public void TroopSpawn(string teamColour, Vector3 position, Quaternion rotation)
    {
        switch (teamColour)
        {
            case "BlueTroop":
                Object.Instantiate(blue, position, rotation);
                break;

            case "RedTroop":
                Object.Instantiate(red, position, rotation);
                break;


        }


    }
}
