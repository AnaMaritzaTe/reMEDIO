using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCamera : MonoBehaviour
{
    public GameObject[] listaCamaras;
    public GameObject muro1;
    public GameObject muro2;
    public int valor = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaCamaras[0].gameObject.SetActive(true);
        listaCamaras[1].gameObject.SetActive(false);
        listaCamaras[2].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (valor == 0)
            {
                listaCamaras[0].gameObject.SetActive(true);
                listaCamaras[1].gameObject.SetActive(false);
                listaCamaras[2].gameObject.SetActive(false);
                ActivarObjeto(muro2);
            }
            if (valor == 1)
            {
                listaCamaras[0].gameObject.SetActive(false);
                listaCamaras[1].gameObject.SetActive(true);
                listaCamaras[2].gameObject.SetActive(false);
                DesactivarObjeto(muro1);
                DesactivarObjeto(muro2);
               
            }
            if (valor == 2)
            {
                listaCamaras[0].gameObject.SetActive(false);
                listaCamaras[1].gameObject.SetActive(false);
                listaCamaras[2].gameObject.SetActive(true);
                ActivarObjeto(muro1);
                valor = -1;
            }
            valor++;

        }
    }
    void ActivarObjeto(GameObject objeto)
    {
        objeto.SetActive(true);
    }

    void DesactivarObjeto(GameObject objeto)
    {
        objeto.SetActive(false);
    }
}
