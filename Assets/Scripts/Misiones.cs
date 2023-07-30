using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Misiones : MonoBehaviour
{
    public Altura tamaño;
    public Semillas fruta;
    public Propiedades propiedades;
    public int misionesCumplidas;
    private List<bool> lista = new List<bool>();
    [SerializeField] private UnityEvent misionCumplida;
    [SerializeField] private UnityEvent misionFallida;


    private void Start()
    {
    }

    public void validarMisionCompleta(Planta planta)
    {
        misionesCumplidas = 0;

        if (tamaño == planta.Altura)
            misionesCumplidas++;
        if (fruta == planta.Fruta)
            misionesCumplidas++;
        if (propiedades == planta.Propiedades)
            misionesCumplidas++;

        if( misionesCumplidas >= 2)
        {
            misionCumplida.Invoke();
        } else
        {
            misionFallida.Invoke();
        }
    }
}
