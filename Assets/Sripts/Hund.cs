using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hund : Tier
{
    public Hund(float gewicht) : base(gewicht)
    {

    }

    public override void Geräusch()
    {
        Debug.Log("Wuff!");
    }
}
