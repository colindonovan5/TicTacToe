using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewGameButton : MonoBehaviour {

    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(OnClick);
	}
	void OnClick()
    {
        GameManager.NewGame();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
