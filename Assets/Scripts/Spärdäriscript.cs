using UnityEngine;
using System.Collections;

public class Spardariscript : MonoBehaviour {

    float speed;
    public Vector2 mouspos;
    public GameObject spärdäri;
    public Vector2 direction;
    public GameObject spärdärilocation,ledique;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            direction = mouspos - (Vector2)spärdärilocation.transform.position;
            spärdäri.GetComponent<Rigidbody2D>().AddForce(direction);
            mouspos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        
        if (Vector2.Distance(spärdärilocation.transform.position, ledique.transform.position) < 3)
        {
            print("success");
        }
	}
}
