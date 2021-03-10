using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoCaja : MonoBehaviour


{

    //Velocidad de la caja
    public float speed = 5f;
     
    //variable para ver si se mueve hacia adelante
    bool forward = true;
    //boleana que me dice si estoy o no, por fuera de los limites.
    bool offLimits = false;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoverCaja();

    }
    void MoverCaja()
    {

        //variables para detectar movimiento y rotar la nave
        float posX = transform.position.x;
        float despX = Input.GetAxis("Horizontal");
        float posZ = transform.position.z;
        float despY = Input.GetAxis("Vertical");
        float posY = transform.position.y;


        //mov de la nave en horizontal
        transform.Translate(Vector3.right * Time.deltaTime * speed * despX);
        //mov de la nave en horizontal
        transform.Translate(Vector3.forward * Time.deltaTime * speed * despY);

        //condición para saber si la nave está dentro del tablero. Boleana que activa posteriormente el texto de cuidado.
        if (posX > 4.5 || posX < -4.5 || posZ > 4.5 || posZ < -4.5)
        {
            offLimits = true;
        }
        else
        {
            offLimits = false;
        }
    }
}
