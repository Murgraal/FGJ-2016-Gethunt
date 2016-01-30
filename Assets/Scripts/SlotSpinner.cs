using UnityEngine;
using System.Collections;

public class SlotSpinner : MonoBehaviour {

    private bool rotate = false;

    public void setRotate(bool rotate)
    {
        this.setRotate = rotate;
    }
	
	void Update () {

        if(rotate)
        {

            transform.Rotate(0, 0, 100 * Time.deltaTime);

        }

    }
}
