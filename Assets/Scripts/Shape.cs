using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour {
    public Sprite Sprite;
    public GameObject Object;
    public Animator ShapeAnimator;
    public Mark CurrentMark;
    bool Animated = false;
    bool Triggered = false;
	// Use this for initialization
	void Start () {
	}
	
    void OnMouseDown() { 
        if (!Animated)
        {
            Triggered = true;
        }
    }
    // Update is called once per frame
    void Update () {
        if (Triggered)
        {
            switch (GameManager.currentMark)
            {
                case Mark.None:
                    print("No Mark Selected");
                    break;
                case Mark.X:
                    ShapeAnimator.SetTrigger("SwitchToX");
                    CurrentMark = GameManager.currentMark;
                    GameManager.NextTurn();
                    Animated = true;
                    break;
                case Mark.O:
                    ShapeAnimator.SetTrigger("SwitchToO");
                    CurrentMark = GameManager.currentMark;
                    GameManager.NextTurn();
                    Animated = true;
                    break;
                default:
                    break;
            }
            Triggered = false;
        }
    }
}
