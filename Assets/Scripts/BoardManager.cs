using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance;
    //Elements
    public int width = 4;
    public int height = 4;
    public Point PointPrefab;
    public Line LinePrefab;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        GenerateBoard();
    }

    //Subrutines
    private void GenerateBoard()
    {
        for (int i = 0; i < height; i=i+1)
        {
            for (int j = 0; j < width; j=j+1)
            {
                //Position
                var p = new Vector2(i, j);
                Instantiate(PointPrefab, p, Quaternion.identity);
                if (j%2==0)
                {
                    Instantiate(LinePrefab, p, Quaternion.Euler(0, 0, 0));
                }
                else
                {
                    Instantiate(LinePrefab, p, Quaternion.Euler(0,180,0));
                }
                //Instantiate(LinePrefab, p, Quaternion.identity);

            }
        }
        //Centering the camera
        var center = new Vector2((float)height / 2 - 0.5f, (float)width / 2 - 0.5f);
        Camera.main.transform.position = new Vector3(center.x, center.y, -5);
    }


    public void SetLine(Line p) //Call when a Line is colored
    {
        GameManager.Instance.SwitchPlayer();

    }

}
