using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCharacter : MonoBehaviour
{
    public controlCamera camara;
    public float velocidad = 5.0f;
    public int indiceCamara;
    public GameObject mesh;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        indiceCamara = camara.valor;

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");


        if (indiceCamara == 1)
        {
            Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, 0.0f) * velocidad * Time.deltaTime;
            if(movimientoHorizontal !=0)
            transform.localEulerAngles = new Vector3(0, movimientoHorizontal > 0 ? 90 : -   90, 0);
            transform.Translate(movimiento,Space.World);
        }
        if (indiceCamara == 0 || indiceCamara == 2)
        {
            Vector3 movimiento = new Vector3(0.0f, 0.0f, movimientoVertical) * velocidad * Time.deltaTime;
            if (movimientoVertical != 0)
                transform.localEulerAngles = new Vector3(0,  movimientoVertical > 0 ? 0 : 180, 0);
            transform.Translate(movimiento, Space.World);
        }




    }

    void RotarMesh()
    {

    } 
}

