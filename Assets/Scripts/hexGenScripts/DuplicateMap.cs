using UnityEngine;
using System.Collections;

public class DuplicateMap : MonoBehaviour {

    public GameObject hexGrid;

	void Start()
    {
        UnityEditor.PrefabUtility.CreatePrefab("prefabs", hexGrid);
    }

    
}
