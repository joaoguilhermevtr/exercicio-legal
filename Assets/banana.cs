using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour {

    public bool crt;
    public int lvlpoke=63;
    public int atkpoke = 50;
    public int poderpoke = 20;
    public int mod = 1; 

    void Start () {

        var Dano = CauDano(lvlpoke, atkpoke, poderpoke, mod);
        if (crt)
        {
            Dano = Dano * 2;
        }
        Debug.Log("Dano= " + Dano);
	}

    int CauDano( int poder, int atk, int lvl, float modifi)
    {
        return ((((((2 * lvl) / 5) + 2) * poder * atk)/50)+2)*mod;
        

    }
}
