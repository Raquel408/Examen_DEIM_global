using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearHuevos : MonoBehaviour
{

    [SerializeField] GameObject Globo;
    //variable para encsillar la pos del gameobject que instancia las bolas
    [SerializeField] Transform InitPos;
    //texto que me dice cuantas bolas hay
    [SerializeField] Text numGlobos;
    //variable para saber numero de bolas en partida
    public int cache;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
