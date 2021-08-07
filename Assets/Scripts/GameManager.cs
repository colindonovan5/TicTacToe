using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
    public static IPlayer playerOne = new Player();
    public static IPlayer playerTwo = new Player();
    public static Mark currentMark = Mark.X;
    public static int PlayerOneWins = 0;
    public static int PlayerTwoWins = 0;
    public Shape Top_Right_Shape = new Shape();
    public Shape Top_Left_Shape;
    public Shape Top_Middle_Shape;
    public Shape Center_Right_Shape;
    public Shape Center_Left_Shape;
    public Shape Center_Shape;
    public Shape Bottom_Left_Shape;
    public Shape Bottom_Right_Shape;
    public Shape Bottom_Middle_Shape;
    public List<Shape> Shapes = new List<Shape>();
    public static 
        int FilledShapes = 0;
    // Use this for initialization
    void Start () {
        Shapes.Add(Top_Left_Shape);
        Shapes.Add(Top_Right_Shape);
        Shapes.Add(Top_Middle_Shape);
        Shapes.Add(Bottom_Left_Shape);
        Shapes.Add(Bottom_Middle_Shape);
        Shapes.Add(Bottom_Right_Shape);
        Shapes.Add(Center_Left_Shape);
        Shapes.Add(Center_Right_Shape);
        Shapes.Add(Center_Shape);
        playerOne.mark = Mark.X;
        playerTwo.mark = Mark.O;
	}
	public static void NextTurn()
    {
        
        if(currentMark == playerOne.mark)
        {
            
            currentMark = playerTwo.mark;
        }else if(currentMark == playerTwo.mark)
        {
            currentMark = playerOne.mark;
        }
        else
        {
            print("No Mark Selected In NextTurn");
        }
        FilledShapes += 1;
    }
	// Update is called once per frame
	void Update () {
        if (Top_Middle_Shape.CurrentMark == Center_Shape.CurrentMark && Center_Shape.CurrentMark == Bottom_Middle_Shape.CurrentMark)
        {
            if (Top_Middle_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Top_Middle_Shape);
            }
        }
        else if (Bottom_Left_Shape.CurrentMark == Center_Left_Shape.CurrentMark && Bottom_Left_Shape.CurrentMark == Top_Left_Shape.CurrentMark)
        {
            if (Bottom_Left_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Bottom_Left_Shape);
            }
        }
        else if (Bottom_Right_Shape.CurrentMark == Center_Right_Shape.CurrentMark && Center_Right_Shape.CurrentMark == Top_Right_Shape.CurrentMark)
        {
            if (Center_Right_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Center_Right_Shape);
            }
        }
        else if (Top_Left_Shape.CurrentMark == Center_Shape.CurrentMark && Center_Shape.CurrentMark == Bottom_Right_Shape.CurrentMark)
        {
            if (Bottom_Right_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Bottom_Right_Shape);
            }
        } else if (Top_Right_Shape.CurrentMark == Center_Shape.CurrentMark && Center_Shape.CurrentMark == Bottom_Left_Shape.CurrentMark)
        {
            if (Center_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Center_Shape);
            }
        } else if(Top_Left_Shape.CurrentMark == Top_Middle_Shape.CurrentMark && Top_Right_Shape.CurrentMark == Top_Middle_Shape.CurrentMark)
        {
            if (Top_Right_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Top_Middle_Shape);
            }
        } else if(Center_Shape.CurrentMark == Center_Right_Shape.CurrentMark && Center_Right_Shape.CurrentMark == Center_Left_Shape.CurrentMark)
        {
            if(Center_Right_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Center_Right_Shape);
            }
        } else if(Bottom_Left_Shape.CurrentMark == Bottom_Middle_Shape.CurrentMark && Bottom_Middle_Shape.CurrentMark == Bottom_Right_Shape.CurrentMark)
        {
            if (Bottom_Left_Shape.CurrentMark != Mark.None)
            {
                SetWinner(Bottom_Left_Shape);
                
            }
        }
        else if (FilledShapes == 9)
        {
            NewGame();
        }



    }
    void SetWinner(Shape CheckedShape)
    {
        switch (CheckedShape.CurrentMark)
        {
            case Mark.None:
                break;
            case Mark.X:
                playerOne.Won = true;
                break;
            case Mark.O:
                playerTwo.Won = true;
                break;
            default:
                break;
        }
        SceneManager.LoadScene("GameOver");
    }
    public static void NewGame()
    {
        //SceneManager.UnloadSceneAsync("GameOver");
        SceneManager.LoadScene("Main");
        playerOne = new Player();
        playerTwo = new Player();
        playerOne.mark = Mark.X;
        playerTwo.mark = Mark.O;
        currentMark = playerOne.mark;
        FilledShapes = 0;
    }
}
