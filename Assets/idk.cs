using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour {

    public int n = 0;
    int R;
   	void Start ()
    {
        Weird(n);
	}
	
    void Weird(int num=0)
    {
        R = n % 2;
        if (R == 0)
        {
            if (n > 2 && n < 5)
            {
                Debug.Log("Não Estranho " + R);
            }
            else
            {
                if (n > 6 && n < 20)
                {
                    Debug.Log("Estranho " + R);
                }
                else
                {
                    if (n < 20)
                    {
                        Debug.Log("Não Estranho " + R);
                    }
                }

            }
        }
        else
        {
            Debug.Log("Estranho " + R);
        }
    }
}
