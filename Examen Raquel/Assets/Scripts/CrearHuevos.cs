using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearHuevos : MonoBehaviour
{

    [SerializeField] GameObject Huevo;
    //variable para encasillar la posicion del gameobject que instancia los huevos
    [SerializeField] Transform Instanciador;
    //texto que me dice cuantos huevos hay
    [SerializeField] Text numHuevos;
    //variable para saber numero de bolas en partida
    public int cache;
    //Variables para generar huevos de forma random
    private float randomNumber;
    Vector3 RandomPos;

    //Distancia entre huevos
    float distanciaSep = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InicioHuevos();
        StartCoroutine("huevosCorrutina");
    }

    //metodo para generar huevos desde el inicio
    void InicioHuevos()
    {
        for (cache = 0; cache < 5; cache++)
        {
            float posRandomx = Random.Range(-4.5f, 4.5f);
            float posRandomz = Random.Range(-4.5f, 4.5f);
            float posRandomy = Random.Range(0f, 4f);
            Vector3 NewPos = new Vector3(posRandomx, posRandomy, posRandomz);
            Vector3 finalPos = Instanciador.position + NewPos;
            Instantiate(Huevo, finalPos, Quaternion.identity);
        }
    }
    //metodo para spaneaew huevos desde cierto tiempo
    void generarHuevo()
    {
        float posRandomx = Random.Range(-10f, 10f);
        float posRandomz = Random.Range(-10f, 10f);
        float posRandomy = Random.Range(0f, 10f);
        Vector3 NewPos = new Vector3(posRandomx, posRandomy, posRandomz);
        Instantiate(Huevo, NewPos, Quaternion.identity);
    }

    //metodo para que aparezcan huevos a mas velocidad
    IEnumerator huevosCorrutina()
    {
        for (cache = 0; cache <= 2; cache++)
        {
            generarHuevo();
            yield return new WaitForSeconds(5);
        }
        for (cache = 3; cache <= 7; cache++)
        {
            generarHuevo();
            yield return new WaitForSeconds(4);
        }
        for (cache = 9; ; cache++)
        {

            generarHuevo();
            yield return new WaitForSeconds(3f);
        }
    }

    //metodo contador de huevos en pantalla
    void contarHuevos()
    {
        numHuevos.text = "Huevos rotos: " + (cache + 6);
    }

}
