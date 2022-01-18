using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]
    private GameObject BlackTile;

    [SerializeField]
    private GameObject WhiteTile;

    //start with two colors (types) later more will be added
    Dictionary<int, GameObject> tileTypes = new Dictionary<int, GameObject>();

    //leave unused to later asign values for tiles with different effects
    private int[,] levelGrid;

    private int _columns = 20;
    private int _rows = 20;

    private float tileSize = 10f;

    private void GenerateGrid()
    {
        levelGrid = new int[_columns, _rows];
        float offsetX = 0;
        float offsetZ = 0;

        for (int i = 0; i < _columns; i++)
        {
            for (int j = 0; j < _rows; j += tileTypes.Count)
            {

                foreach (var item in tileTypes)
                {
                    levelGrid[i, j] = Random.Range(1, tileTypes.Count+1);
                    GameObject currentTile = Instantiate(tileTypes[levelGrid[i, j]], transform.localPosition + new Vector3(offsetX, 0, offsetZ), Quaternion.identity);
                    Debug.Log(currentTile.transform.localPosition);
                    offsetX += tileSize;
                }
            }

            offsetZ += tileSize;
            offsetX = 0;
        }

    }


    private void Awake()
    {
        tileTypes.Add(1, BlackTile);
        tileTypes.Add(2, WhiteTile);
        Debug.Log($"Length de tileTypes es: {tileTypes.Count}");
    }


    void Start()
    {
        GenerateGrid();
    }


    void Update()
    {

    }
}
