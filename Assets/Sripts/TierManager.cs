using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TierManager : MonoBehaviour
{
    private void Start()
    {
        Tier meinHund = new Hund(25.0f);
        Debug.Log("Gewicht des Hundes: " +  meinHund.gewicht);
        meinHund.Geräusch();
    }
}
