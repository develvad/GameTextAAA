using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
        text.text = "¡ Que Comience el juego !";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowMessageInCanvas(string gameText)
    {
        text.text = gameText;
    }
}
