using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlMenus : MonoBehaviour
{
    //public GameObject portada;
    public GameObject menuInicio;
    public GameObject controles;

    void Start()
    {
        ActivarObjeto(menuInicio);
    }

    void Update()
    {
        /*if (Input.anyKeyDown)
        {
            DesactivarObjeto(portada);
            ActivarObjeto(menuInicio);
        }*/
    }

    void ActivarObjeto(GameObject objeto)
    {
        objeto.SetActive(true);
    }

    void DesactivarObjeto(GameObject objeto)
    {
        objeto.SetActive(false);
    }

    public void Jugar()
    {
        SceneManager.LoadScene("videointro"); 
    }

    public void Salir()
    {
        Debug.Log("Saliendo.....");
        Application.Quit();
    }

    public void Controles()
    {
        ActivarObjeto(controles);
        DesactivarObjeto(menuInicio);
    }

    public void Volver()
    {
        ActivarObjeto(menuInicio);
        DesactivarObjeto(controles);
    }
    public void Logros()
    {
        SceneManager.LoadScene("LogrosScene");
    }
}

