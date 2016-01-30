using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {

    //effectId = 0 neutral
    //effectId = 1 friendly
    //effectId = 2 flirty
    //effectId = 3 cheesy
    //effectId = 4 fuck with
    //effectId = 5 aggressive
    //effectId = 6 idiot

    public static PlayerData Instance = null;

    public float hp;
    public float dmg;
    public float drunkLvl;
    public float neutralResist;
    public float friendlyResist;
    public float flirtyResist;
    public float cheesyResist;
    public float fuckwithResist;
    public float aggressiveResist;
    public float idiotResist;

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
