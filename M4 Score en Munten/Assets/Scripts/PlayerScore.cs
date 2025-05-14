using UnityEngine;
using System.Collections.Generic;

public class PlayerScore : MonoBehaviour
{
    public int score = 0; // Variabele voor score
    public List<int> coins = new(); // Lijst voor munten

    void Start()
    {
        // Loop: toon 3x een startbericht
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Spel begint!");
        }
    }

    void Update()
    {
        // If-statement: check of score >= 50
        if (score >= 50)
        {
            Debug.Log("Je hebt gewonnen!");
        }

        // Test: druk op spatie om een munt toe te voegen
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddCoin(10); // Roep functie AddCoin() aan en geef als arguement 10 punten mee
        }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {
        coins.Add(1); // Voeg munt toe aan lijst

        for (int i = 0; i < coinValue; i++) // verhoog score met de waarde van AddCoin
        {
            score++;
        }

        Debug.Log("Munt gepakt! Score: " + score);
        Debug.Log("Aantal munten: " + coins.Count);
    }
}

