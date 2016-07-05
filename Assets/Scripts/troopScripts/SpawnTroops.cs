using UnityEngine;
using System.Collections;

public class SpawnTroops : MonoBehaviour
{
    
    public GameObject blue, red;

    public GameObject bForce, rForce;

    
    
    //Method to spawn troop based on team colour
    public void TroopSpawn(string teamColour, Vector3 position, Quaternion rotation)
    {

        Vector3 BigPos = new Vector3(0, 0, 20);
        switch (teamColour)
        {
            case "BlueTroop":
                Object.Instantiate(blue, position, rotation);
                ForceSpawn(teamColour, BigPos, rotation);
                break;

            case "RedTroop":
                Object.Instantiate(red, position, rotation);
                ForceSpawn(teamColour, BigPos, rotation);
                break;
        }
    }

    public void ForceSpawn(string teamColour, Vector3 position, Quaternion rotation)
    {
        switch (teamColour)
        {
            case "BlueTroop":
                Object.Instantiate(bForce, position, rotation);
                break;

            case "RedTroop":
                Object.Instantiate(rForce, position, rotation);
                break;
        }
    }
}
