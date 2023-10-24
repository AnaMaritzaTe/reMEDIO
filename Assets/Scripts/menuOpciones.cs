using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuOpciones : MonoBehaviour
{
   // public GameObject VideoInicio;
    
    public GameObject btnPause;
    public GameObject menuPause;
    public GameObject controles;
   // public GameObject menuPause;


    void Update()
    {
        
    }

    void ActivarObjeto(GameObject objeto)
    {
        objeto.SetActive(true);
    }

    void DesactivarObjeto(GameObject objeto)
    {
        objeto.SetActive(false);
    }

    public void Pause()
    {
        ActivarObjeto(menuPause);
        
    }
    public void Continuar()
    {
        DesactivarObjeto(menuPause);

    }
    public void Salir()
    {
        Debug.Log("Saliendo.....");
        Application.Quit();
    }
    public void Controles()
    {
        ActivarObjeto(controles);
        DesactivarObjeto(menuPause);
        DesactivarObjeto(btnPause);
    }
    public void Volver()
    {
        ActivarObjeto(menuPause);
        DesactivarObjeto(controles);
        ActivarObjeto(btnPause);
    }

}
