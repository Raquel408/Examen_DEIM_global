using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    //Variables necesarias para la opción de suavizado en el seguimiento
    [SerializeField] float smoothVelocity;
    private Vector3 camaraVelocity = Vector3.zero;

    //variable para la posicion de la nave
    [SerializeField] Transform localizacionCaja;
    //variable para el sonido
    private AudioSource backgroundSound;

    // Start is called before the first frame update
    void Start()
    {
        //Damos una velocidad de suavizado en el seguimiento
        smoothVelocity = 0.1f;
        //audio
        backgroundSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //la posicion de la camara va a seguir la de la caja
        transform.LookAt(localizacionCaja);
        transform.position = new Vector3(transform.position.x, localizacionCaja.position.y + 3.5f, localizacionCaja.position.z + 4);
        

        
        //Estas líneas de código hacen que la cámara siga al objeyivo (targetPosition) con suavidad (smoothVelocity)
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y + 0.5f, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);

    }
}
