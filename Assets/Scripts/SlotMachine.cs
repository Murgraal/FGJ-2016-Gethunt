using UnityEngine;
using System.Collections;

public class SlotMachine : MonoBehaviour
{

    private float winningProbability = 0.3f;
    public SpriteRenderer[] sr;
    public GameObject[] slots;
    public Sprite[] sprites;
    private bool rotate;

    public void use(/*PlayerData player*/)
    {

        //player.money -= 1;

        bool winning = false;

        float coinToss = Random.Range(0f, 1f);

        if (coinToss <= winningProbability)
        {
            winning = true;
        }

        if (winning)
        {

            int result = Random.Range(0, 2);

            if (result == 0)
            {
                setRandomGraphicsWinning1();
                //player.money += 2;
            }
            else if (result == 1)
            {
                setRandomGraphicsWinning2();
                //player.money += 3;
            }
            else
            {
                setRandomGraphicsWinning3();
                //player.money += 4;
            }

        }
        else
        {
            setCrapRandomGraphics();
        }

    }

    public IEnumerator something()
    {
        setSpinningGraphics();
        rotate = true;
        yield return new WaitForSeconds(1f);
        rotate = false;
        this.use();
    }

    void Update()
    {

        if (rotate)
        {
            slots[0].transform.Rotate(0, 0, 1000 * Time.deltaTime);
            slots[1].transform.Rotate(0, 0, 1000 * Time.deltaTime);
            slots[2].transform.Rotate(0, 0, 1000 * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.A) && !rotate)
        {

            StartCoroutine(something());
        }

    }


    public void setSpinningGraphics()
    {

        sr[0].sprite = sprites[0];
        sr[1].sprite = sprites[0];
        sr[2].sprite = sprites[0];

    }

    public void setCrapRandomGraphics()
    {
        sr[0].sprite = sprites[1];
        sr[1].sprite = sprites[2];
        sr[2].sprite = sprites[3];

    }

    public void setRandomGraphicsWinning1()
    {
        sr[0].sprite = sprites[1];
        sr[1].sprite = sprites[1];
        sr[2].sprite = sprites[1];
    }

    public void setRandomGraphicsWinning2()
    {
        sr[0].sprite = sprites[2];
        sr[1].sprite = sprites[2];
        sr[2].sprite = sprites[2];
    }

    public void setRandomGraphicsWinning3()
    {

        sr[0].sprite = sprites[3];
        sr[1].sprite = sprites[3];
        sr[2].sprite = sprites[3];

    }
}
