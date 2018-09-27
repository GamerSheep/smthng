using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduktion : MonoBehaviour
{

    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float a;
    public float b;
    public int height = 8;
    public int bas;
    public float vinkel;
    public float bitar;
    public string namn;
    public float radie;
    public int damage;
    public int demonhealth;
    public int demoncount;
    public int minDamage;
    public int maxDamage;
    public int count;
    public int multicount;
    public int enemyDmg;
    public float Resinstance;
    public int playerMaxHealth;

    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5a();
        Uppgift5b();
        Uppgift6();
        Uppgift7();
        Uppgift8a();
        Uppgift8b();
        Uppgift8c();
        Uppgift8d();
        Uppgift10();
        Uppgift11();
    }

    void Uppgift1()
    {
        Debug.Log(
            string.Format(
                "svaret på (963 * 421) - (175463 / 87) är {0}"
            , (963f * 421f) - (175463f / 87f)));
    }

    void Uppgift2()
    {
        //skriva ut testmeningar sentence1 sentence2 och sentence3, låt användaren i unity skriva egna
        Sentence1();
        Sentence2();
        Sentence3();
    }

    void Sentence1()
    {
        Debug.Log(sentence1);
    }

    void Sentence2()
    {
        Debug.Log(sentence2);
    }

    void Sentence3()
    {
        Debug.Log(sentence3);
    }

    void Uppgift3()
    {
        //Låt användaren skriva in ett tal number, skriv sedan ut vad number upphöjt med 2 blir, samt kvadratroten ur number. 
        //Använd funktionerna 	Mathf.Pow(a, b) (a upphöjt med b) och Mathf.Sqrt(a) (kvadratroten ur a).
        Debug.Log(string.Format("talet {0} upphöjt med 2 blir {1} och kvr ur {0} blir {2}",
            a, Mathf.Pow(a, 2), Mathf.Sqrt(a)));

    }

    void Uppgift4()
    {
        //Räkna ut arean på en triangel med höjden 8, låt användaren bestämma basen base. Skriv ut resultaten i m^2.
        Debug.Log(string.Format("talet {0} gånger {1} delat med 2 blir {2}",
            height, bas, height * bas / 2));
    }

    void Uppgift5a()
    {
        //användaren skriva in vinkel, ge antal hela tårtbitar, gradtecken = °
        Debug.Log(string.Format(
            "om vinkel är {0} kan man skära tårtan i {1} bitar"
            ,vinkel, 360 / vinkel));
    }
    void Uppgift5b()
    {
        //användarn skriva in antal bitar, ge vinkeln av bitarna
        Debug.Log(string.Format(
            "om antalet bitar är {0} så är vinkeln {1}"
            , bitar, 360 / bitar));

    }

    void Uppgift6()
    {
        //skriva namn, prefix "boss", ändelse "of doom"
        Debug.Log(string.Format(
            "{0} {1} {2}"
            , "Boss", namn, "of doom"));
    }

    void Uppgift7()
    {
        //skriva radie, beräkna volymen av 2978 klot
        Debug.Log(string.Format("om radien är {0} så blir volymen {1} för 2978 st. klot"
            , radie, (4 * Mathf.PI * Mathf.Pow(radie, 3) / 3)*2978 ));
    }

    void Uppgift8a()
    {
        //skriv in damage, hur många attacker för att döda 890000
        Debug.Log(string.Format("med skadan {0} så tar det {1} st attacker för att döda demonen"
            , damage, 890000 / damage));
    }

    void Uppgift8b()
    {
        //skriv in egen skada och health för demonen
        Debug.Log(string.Format("om demonen har {0} health så tar det {1} attacker med skadan {2}"
            , demonhealth, demonhealth / damage, damage ));
    }

    void Uppgift8c()
    {
        //låt användaren skriva in antalet demoner
        Debug.Log(string.Format("om du gör {0} skada så tar det {1} attacker för att döda {2} demoner med health {3}"
            , damage, (demonhealth * demoncount) / damage, demoncount, demonhealth ));
    }

    void Uppgift8d()
    {
        //skriva in minDamage och maxDamage och räkna ut max, min och snitt för att döda
        Debug.Log(string.Format("om du har skada {0} och {1} så tar det max {2} och minst {3} attacker, i genomsnitt tar det {4}"
            , minDamage, maxDamage, (demonhealth * demoncount) / minDamage,
            (demonhealth * demoncount) / maxDamage, (demonhealth * demoncount) / (minDamage * maxDamage / 2)));
    }

    void Uppgift9()
    {
        //Skapa ett värde count, gör så att värdet dubbleras varje frame. Skriv ut resultatet varje frame.
        //halp
    }

    void Uppgift10()
    {
        //Skapa ett värde countMulti, multiplicera det med 3 och dela det därefter med 2. Skriv ut värdet.
        Debug.Log(string.Format("{0} gånger 3 delat med 2 blir {1}"
            , multicount, (multicount * 3) / 2));
    }

    void Uppgift11()
    {
        //Skapa 3 variabler, playerMaxLife, playerResist, enemyDamage.Gör så att spelaren tar skadan enemyDamage, men den reduceras med playerResist.Låt playerResist vara ett procentvärde(0 till 1) och multiplicera skadan med det.
        Debug.Log(string.Format("om fienden gör {0} skada och du har restistance {1} så tar du {2} skada"
            , enemyDmg, Resinstance, enemyDmg * Resinstance)); 
    }

    // Update is called once per frame
    void Update()
    {
        count = count * 2;
        Debug.Log(count);
    }

}
