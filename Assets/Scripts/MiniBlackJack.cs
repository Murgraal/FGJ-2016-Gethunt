using UnityEngine;
using System.Collections;
using System;

public class MiniBlackJack : MonoBehaviour {

    public GameObject[] cards;
    public GameObject[] dealerHand;
    public GameObject[] playerHand;
    public int nextcard;   

    public void startHand()
    {
        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        dealerHand[0] = cards[nextcard];
        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        dealerHand[1] = cards[nextcard];
        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        playerHand[0] = cards[nextcard];
        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        playerHand[1] = cards[nextcard];

        int playerValue = calculateValue(playerHand);
        int dealerValue = calculateValue(dealerHand);

        if(playerValue > dealerValue)
        {
            print("YOU WON");
        }
        else
        {
            print("YOU LOSE");
        }

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            startHand();
        }
    }

    public int calculateValue(GameObject[] hand)
    {

        int i = 0;

        foreach(GameObject card in hand)
        {
            i += Int32.Parse(card.name);
        }

        return i;

    }

    private int getCard()
    {
        return UnityEngine.Random.Range(0, cards.Length - 1);
    }

}
