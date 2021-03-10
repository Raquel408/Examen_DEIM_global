using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    //variable para la posicion de la nave
    [SerializeField] Transform localizacionCaja;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //la posicion de la camara va a seguir la de la caja
        transform.LookAt(localizacionCaja);
        transform.position = new Vector3(transform.position.x, localizacionCaja.position.y + 5, localizacionCaja.position.z + 15);
        //la camara mira todo el rato a la caja
        transform.LookAt(localizacionCaja);

    }
}
