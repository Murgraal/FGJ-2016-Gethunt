using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TargetPerson { Bartender, CockBlocker, Portsari, Babe };

public class PlayerCombat : MonoBehaviour {

    public static PlayerCombat Instance = null;

    public List<string> _Playermsgs;
    TargetPerson _targetPersons;

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
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {

        }
    }

    public void Attack()
    {
        //Implement PlayerAttack();
    }
}
