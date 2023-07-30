using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreadorPlantas : MonoBehaviour
{
    private Planta planta;
    private List<Liquidos> liquidosAgregados = new List<Liquidos>();
    private Semillas semillaAgregada;
    private Propiedades propiedadAgregada;
    private int liquidoMaximo = 3;

    public Button agua;
    public Button coca;
    public Button energizante;

    public Button fruta1;
    public Button fruta2;
    public Button fruta3;

    public Button prop1;
    public Button prop2;
    public Button prop3;

    private PlantScript plantScript;
    public GameObject contenedor;
    public GameObject plantaPequeña;
    public GameObject plantaMediana;
    public GameObject plantaGrande;
    private GameObject plantaInstanciada;

    public Button entregarPlanta;
    public Misiones misionActual;

    // Start is called before the first frame update
    void Start()
    {
        planta = new Planta();
        agua.onClick.AddListener(() =>{ addLiquidos(Liquidos.Agua); });
        coca.onClick.AddListener(() =>{ addLiquidos(Liquidos.Coca); });
        energizante.onClick.AddListener(() =>{ addLiquidos(Liquidos.Energizante); });

        fruta1.onClick.AddListener(() => { addSemillas(Semillas.Fruta1); });
        fruta2.onClick.AddListener(() => { addSemillas(Semillas.Fruta2); });
        fruta3.onClick.AddListener(() => { addSemillas(Semillas.Fruta3); });

        prop1.onClick.AddListener(() => { addPropiedades(Propiedades.Propiedad1); });
        prop2.onClick.AddListener(() => { addPropiedades(Propiedades.Propiedad2); });
        prop3.onClick.AddListener(() => { addPropiedades(Propiedades.Propiedad3); });

        entregarPlanta.onClick.AddListener(() => { misionActual.validarMisionCompleta(planta); });

    }

    public void addLiquidos(Liquidos liquidos)
    {
        liquidosAgregados.Add(liquidos);
        if (liquidosAgregados.Count == liquidoMaximo)
        {
            disableButtonsLiquidos();
        }
    }


    public void addSemillas(Semillas semillas)
    {
        semillaAgregada = semillas;
        planta.Fruta = semillas;
    }

    public void addPropiedades(Propiedades propiedades)
    {
        propiedadAgregada = propiedades;
        planta.Propiedades = propiedades;
    }

    public void validarPlanta()
    {
        validarAltura();
        foreach (Transform child in contenedor.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        switch (planta.Altura)
        {
            case Altura.Pequeña:
                plantaInstanciada = Instantiate(plantaPequeña, contenedor.transform);
                break;
            case Altura.Mediana:
                plantaInstanciada = Instantiate(plantaMediana, contenedor.transform);
                break;
            case Altura.Grande:
                plantaInstanciada = Instantiate(plantaGrande, contenedor.transform);
                break;
            default:
                break;
        }

        plantScript = plantaInstanciada.GetComponent<PlantScript>();

        plantScript.setFruits(planta.Fruta);
        plantScript.setPot(planta.Propiedades);


        Debug.Log(planta.Altura.ToString());
        Debug.Log(planta.Fruta.ToString());
        Debug.Log(planta.Propiedades.ToString());
    }


    void disableButtonsLiquidos()
    {
        agua.interactable = false;
        coca.interactable = false;
        energizante.interactable = false;
    }

    void disableButtonsFrutas()
    {
        fruta1.interactable = false;
        fruta2.interactable = false;
        fruta3.interactable = false;
    }

    void disableButtonsPropiedades()
    {
        prop1.interactable = false;
        prop2.interactable = false;
        prop3.interactable = false;
    }

    private void validarAltura()
    {
        int altura = 0;
        foreach (var liquido in liquidosAgregados)
        {
            altura += (int)liquido;
        }

        if (altura >= 1 && altura <= 2)
        {
            planta.Altura = Altura.Pequeña;
            return;
        }

        if (altura > 2 && altura <= 5)
        {
            planta.Altura = Altura.Mediana;
            return;
        }

        if ( altura > 5) 
        {
            planta.Altura = Altura.Grande;
            return;
        }
    }

}
