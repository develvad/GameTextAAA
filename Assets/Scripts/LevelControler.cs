using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Level
{
    [TextArea]
    public string description;

    public Enemy enemy;

    //[SerializeField]
    //int id;


    [SerializeField]
    public int prevLevel;

    [SerializeField]
    public int nextLevel;
}

public class LevelControler : MonoBehaviour {

    public Level currentLevel;

    [SerializeField]
    Level[] levels;

	// Use this for initialization
	void Start () {
        currentLevel = levels[0];
	}
	
	// Update is called once per frame
	public void Next (Level level) {
  
        currentLevel = levels[level.nextLevel];
	}

    public void Prev(Level level)
    {
     
        currentLevel = levels[level.prevLevel];
    }
}
