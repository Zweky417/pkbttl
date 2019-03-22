using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrParImpar : MonoBehaviour {

    public int n = 3;

	void Start () 
    {
        int resul;

        resul = n % 2;

        if (resul == 1)
        {
            Debug.Log("Estranho");
        }
        else if (resul == 0 && n >= 2 && n <= 5)
        {
            Debug.Log("Não estranho");
        }
        else if (resul == 0 && n >= 6 && n <= 20)
        {
            Debug.Log("Estranho");
        }
        else if (resul == 0 && n > 20)
        {
            Debug.Log("Não estranho");
        }
	}
}
