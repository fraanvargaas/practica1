using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linterna : MonoBehaviour
{
    public GameObject luzobjeto;
    public bool activa;
    public bool luz;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            activa = !activa;
            if (activa == true)
            {
                luzobjeto.SetActive(true);
            }
            if (activa == false)
            {
                luzobjeto.SetActive(false);
            }
        }
    }
}
