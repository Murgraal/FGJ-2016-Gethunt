using UnityEngine;
using System.Collections;

public class SlotMachine : MonoBehaviour
{

    private float winningProbability = 0.3f;

    public void use(PlayerData player)
    {

        player.money -= 1;

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
                player.money += 2;
            }
            else if (result == 1)
            {
                player.money += 3;
            }
            else
            {
                player.money += 4;
            }

        }

    }


}
