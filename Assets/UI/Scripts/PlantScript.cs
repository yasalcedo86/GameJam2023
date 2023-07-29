using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantScript : MonoBehaviour
{
    public Image pot;
    public Image[] fruits;

    void Start()
    {
        //setFruits(1);
        //setPot(2);
    }

    public void setFruits(Semillas fruitNumber)
    {
        foreach (Image fruit in fruits)
        {
            fruit.sprite = Resources.Load<Sprite>("UI/Fruits/" + (int)fruitNumber);
        }
    }

    public void setPot(Propiedades potNumber)
    {
        pot.sprite = Resources.Load<Sprite>("UI/Pots/" + (int)potNumber);
    }
}