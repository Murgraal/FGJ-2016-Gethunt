using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {

    public static PlayerData Instance = null;

    public float hp;
    public float dmg;
    public float drunkLvl;

	// Use this for initialization
	void Start () {

        hp = 100;
        dmg = 10;
        drunkLvl = 1;

	
	}
	
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
