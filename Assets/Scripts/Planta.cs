using System.Collections;
using System.Collections.Generic;



public class Planta
{
    private Altura _altura;
    private Semillas _fruta;
    private Propiedades _propiedades;

    public Altura Altura { get => _altura; set => _altura = value; }
    public Semillas Fruta { get => _fruta; set => _fruta = value; }
    public Propiedades Propiedades { get => _propiedades; set => _propiedades = value; }
}
