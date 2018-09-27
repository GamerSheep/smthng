using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelTest : MonoBehaviour
{

    public int UserValue;
    public int Dice = 10;
    [Header("dragon")]
    public int DragonHealth;
    public int PlayerHealth = 100;
    public int Chance;
    public int EncChance;
    public int CritChance;
    [Header("higher lower")]
    public int startvalue;

    // Use this for initialization
    void Start()
    {
        DragonHealth = (Random.Range(100, 151));

        EncChance = (Random.Range(1, 11));
        if (EncChance == 2)
        {
            DragonHealth *= 2;
        }
        else
        {
            DragonHealth *= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Uppgift1
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            UserValue += 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            UserValue /= 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(UserValue);
        }

        //Uppgift2:
        if (Input.GetKeyDown(KeyCode.R))
        {
            Dice += Random.Range(1, 7);
            Dice -= Random.Range(1, 7);
        }
        if (Dice >= 20)
        {
            Debug.Log("You Win");
        }
        if (Dice <= 0)
        {
            Debug.Log("YouLose");
        }

        //Uppgift3
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Chance += (Random.Range(1, 3));
            DragonHealth -= (Random.Range(5, 26));
            if (Chance == 1)
            {
                PlayerHealth -= 0;
            }
            if (Chance == 2)
            {
                PlayerHealth -= (Random.Range(10, 21));
            }
            Chance = 0;
            if (PlayerHealth <= 0)
            {
                Debug.Log("You Lose");
            }
            if (DragonHealth <= 0)
            {
                Debug.Log("You Win");
            }

            //Uppgift 4
            CritChance = (Random.Range(1, 101));
            if (CritChance <= 5)
            {
                DragonHealth -= 300;
            }


        }
    }

}
