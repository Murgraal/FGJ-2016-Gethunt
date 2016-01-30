using UnityEngine;
using System.Collections;
using System;

public class MiniBlackJack : MonoBehaviour {

    public GameObject[] cards;
    public SpriteRenderer[] dealerNumber,dealerSymbol;
    public SpriteRenderer[] playerNumber, playerSymbol;
    public Sprite[] numbers;
    public Sprite[] symbols;
    public int nextcard;

    public void startHand()
    {

        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        dealerNumber[0].sprite = numbers[nextcard];
        dealerSymbol[0].sprite = symbols[UnityEngine.Random.Range(0, symbols.Length - 1)];
        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        dealerNumber[1].sprite = numbers[nextcard];
        dealerSymbol[1].sprite = symbols[UnityEngine.Random.Range(0, symbols.Length - 1)];
        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        playerNumber[0].sprite = numbers[nextcard];
        playerSymbol[0].sprite = symbols[UnityEngine.Random.Range(0, symbols.Length - 1)];
        nextcard = UnityEngine.Random.Range(0, cards.Length - 1);
        playerNumber[1].sprite = numbers[nextcard];
        playerSymbol[1].sprite = symbols[UnityEngine.Random.Range(0, symbols.Length - 1)];

        int playerValue = calculateValue(playerNumber);
        int dealerValue = calculateValue(dealerNumber);

        if (playerValue > dealerValue)
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

    public int calculateValue(SpriteRenderer[] hand)
    {

        int i = 0;

        foreach (SpriteRenderer number in hand)
        {
            int x = (Int32.Parse(number.sprite.name.Split(new char[] { '_' })[1]) + 1);

            if (x == 13)
            {
                i += 1;
            }
            else if(x >= 10)
            {
                i += 10;
            } 
            else
            {
                i += x;
            }            

        }

        return i;

    }

    private int getCard()
    {
        return UnityEngine.Random.Range(0, cards.Length - 1);
    }

}