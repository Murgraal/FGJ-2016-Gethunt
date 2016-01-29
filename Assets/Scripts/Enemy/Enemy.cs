using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public float _morale;
    public float dmg;

	// Use this for initialization
	void Start () {

        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (_morale <= 0.0f)
        {
            KillPlayer();
        }
    }

    public void ReduceMorare(float _reduce)
    {
        _morale -= _reduce;
    }

    public void Attack()
    {
        //implement player morale reduce here
    }

    public void Talk(string _dialogue)
    {
        //implement dialogue here
    }

    public void KillPlayer()
    {
        //trigger death & reset
    }
}
