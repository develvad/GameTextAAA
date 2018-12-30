
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Easyest versión of Singleton class
    public static GameManager instance;

    [SerializeField] LevelControler lvlContoler;
    [SerializeField] UIManager uiManager;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        uiManager.ShowMessageInCanvas(lvlContoler.currentLevel.description);
	}
	
	// Update is called once per frame
	void Update ()
    {   
        if (Input.GetKeyDown(KeyCode.W))
        {
            lvlContoler.Next(lvlContoler.currentLevel);
            ShowMessage(lvlContoler);


        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            lvlContoler.Prev(lvlContoler.currentLevel);
            ShowMessage(lvlContoler);


        }

    }
    public void ShowMessage(LevelControler lvlObj)
    {
        string ifHaveEnemy = " - (E) Atacar Enemigo";
        if (lvlObj.currentLevel.enemy != null)
        {
            uiManager.ShowMessageInCanvas(lvlObj.currentLevel.description + ifHaveEnemy);
        }
        else
        {
            uiManager.ShowMessageInCanvas(lvlObj.currentLevel.description);
        }
    }
    private void OnMouseDown()
    {
        
    }
}
