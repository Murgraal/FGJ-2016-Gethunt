using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    int animId = 0;
    int currentAnimId = 0;
    Vector3 moveTarget;
    public Animator animator;
	void Start ()
    {
        moveTarget = transform.position;
        //anim.Play("MikiDance");
    }
	
	void Update ()
    {
        ClickToMove();
        AnimCont();
        Move();
	}
    void Move()
    {
        float d = Vector3.Distance(transform.position, moveTarget);
        if (d > 1.0f)
        {
            transform.position = Vector3.Lerp(transform.position, moveTarget, Time.deltaTime * 0.7f);
            animId = 1;
        }
        else
            animId = 0;
    }
    void AnimCont()
    {
        if (currentAnimId != animId)
        {
            animator.SetInteger("AnimId", animId);
            currentAnimId = animId;
        }
        /*
            
            if(animId == 0)
                anim.CrossFade("MikiDance", 0.5f);
            else if(animId == 1)
                anim.CrossFade("MikiWalk", 0.5f);
            
        }*/
    }
    void ClickToMove()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100, (1 << 8)))
            {
                moveTarget = hit.point;
            }
        }
    }
}
