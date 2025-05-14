using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tier : MonoBehaviour
{
    public float gewicht;
    public Tier(float gewicht)
    {
        this.gewicht = gewicht;
    }
    public virtual void Geräusch()
    {
        Debug.Log("Gibt Laut");
    }
}
