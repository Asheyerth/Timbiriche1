using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Line : MonoBehaviour
{
    public GameObject Inner;

    //Line
    private Vector2 _position;
    public Vector2 Pos => _position; //get
    public void Init(Vector2 position)
    {
        this._position = position;
    }

    private void OnMouseDown()
    {
        Debug.Log("mouse down");
        Debug.Log("Point Line click on " + _position.x + ", " + _position.y); //Alone
        //Click --> Change color
        //By players
        if (GameManager.Instance.GetGameState == GameManager.GameState.player1A || GameManager.Instance.GetGameState == GameManager.GameState.player1B)
            Inner.GetComponent<SpriteRenderer>().color = Color.magenta; //Click --> Change color
        else
            if(GameManager.Instance.GetGameState == GameManager.GameState.player2A || GameManager.Instance.GetGameState == GameManager.GameState.player2B)
            Inner.GetComponent<SpriteRenderer>().color = Color.cyan; //Click --> Change color
            else
                Inner.GetComponent<SpriteRenderer>().color = Color.red; //Click --> Change color

        BoardManager.Instance.SetLine(this);
    }
}
