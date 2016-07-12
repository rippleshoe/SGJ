using UnityEngine;
using System.Collections;

public class CopyHeights : MonoBehaviour
{

    public GameObject MainMap;

    public GameObject[] mapCells;
    HexGrid HG;
    GenerateHeights GH;

    string MapTag;


    public void CopyHeightMap(GameObject[] BigCells)
    {
        //get Generate Heights Component and HexGrid Component;
        GenerateHeights GH = MainMap.GetComponent<GenerateHeights>();
        HexGrid HG = gameObject.GetComponent<HexGrid>();
        MapTag = HG.instanceTag;




        mapCells = GameObject.FindGameObjectsWithTag(MapTag);

        for (int i = 0; i <= mapCells.Length - 1; i++)
        {
            HexCell hc = mapCells[i].GetComponent<HexCell>();
            HexCell bc = BigCells[i].GetComponent<HexCell>();
            hc.Elevation = bc.Elevation;
        }


        for (int i = 0; i <= mapCells.Length - 1; i++)
        {
            HexCell hc = mapCells[i].GetComponent<HexCell>();
            if (hc.Elevation >= 6)
            {
                hc.color = Color.grey;
            }
            else if (hc.Elevation >= 3)
            {
                hc.color = Color.green;
            }
            else
            {
                hc.color = Color.blue;
            }
        }
        HexGrid hg = gameObject.GetComponent<HexGrid>();
        hg.Refresh();

    }


}
    
    

