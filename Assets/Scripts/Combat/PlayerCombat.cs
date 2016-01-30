using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class PlayerCombat : MonoBehaviour {

    public static PlayerCombat Instance = null;



    // Use this for initialization
    void Start () {
	
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
    void Update()
    {
    }


    

}
