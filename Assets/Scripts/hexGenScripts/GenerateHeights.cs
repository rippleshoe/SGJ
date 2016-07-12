using UnityEngine;
using System.Collections;

public class GenerateHeights : MonoBehaviour {

    public GameObject[] cells;
    public GameObject blueMap, redMap;
    public string Bluebase;

    void Start()
    {
        cells = GameObject.FindGameObjectsWithTag("BigCells");

        for (int i = 0; i <= cells.Length - 1; i++)
        {
            HexCell hc = cells[i].GetComponent<HexCell>();
            hc.Elevation = 2;
        }

        Debug.Log("All level 3");

        for (int y = 0; y <= 17; y++)
        {
            Debug.Log("Starting Loop: " + y);
            int randCellNum = Random.Range(0, (cells.Length - 1));
            HexCell hRC = cells[randCellNum].GetComponent<HexCell>();
            if (!hRC.HeightSet)
            {
                hRC.Elevation = Random.Range(6, 7);
                hRC.HeightSet = true;

                for (int z = 0; z <= 5; z++)
                {
                    if (hRC.neighbors[z] != null)
                    {
                        HexCell hRNC = hRC.neighbors[z].GetComponent<HexCell>();

                        hRNC.Elevation = Random.Range(3, 6);
                        hRNC.HeightSet = true;

                    }

                }
            }
            else
                y -= 1;

        }

        for (int y = 0; y <= 10; y++)
        {
            Debug.Log("Starting Loop: " + y);
            int randCellNum = Random.Range(20, (cells.Length - 1));
            HexCell hRC = cells[randCellNum].GetComponent<HexCell>();
            if (!hRC.HeightSet)
            {
                hRC.Elevation = 0;
                hRC.HeightSet = true;

                for (int z = 0; z <= 5; z++)
                {
                    if (hRC.neighbors[z] != null)
                    {
                        HexCell hRNC = hRC.neighbors[z].GetComponent<HexCell>();

                        hRNC.Elevation = Random.Range(1, 4);
                        hRNC.HeightSet = true;
                    }
                }
            }
        }

        for (int i = 0; i <= cells.Length - 1; i++)
        {
            HexCell hc = cells[i].GetComponent<HexCell>();
            if (hc.coordinates.Z == 0 || hc.coordinates.Z == 19)
            {
                hc.Elevation = 7;
                hc.HeightSet = true; 
            }
            if (!hc.HeightSet)
            {
                hc.Elevation = Random.Range(3, 4);
            }

        }

        

        for (int i = 0; i <= cells.Length - 1; i++)
        {
            HexCell hc = cells[i].GetComponent<HexCell>();
            if (hc.Elevation >= 6)
            {
                hc.color = Color.white;
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

        CopyHeights blueCH = blueMap.GetComponent<CopyHeights>();
        CopyHeights redCH = redMap.GetComponent<CopyHeights>();

        blueCH.CopyHeightMap(cells);
        redCH.CopyHeightMap(cells);


    }

    

    }
