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
        setFruits(1);
        setPot(2);
    }

    public void setFruits(int fruitNumber)
    {
        foreach (Image fruit in fruits)
        {
            fruit.sprite = Resources.Load<Sprite>("UI/Fruits/" + fruitNumber);
        }
    }

    public void setPot(int potNumber)
    {
        pot.sprite = Resources.Load<Sprite>("UI/Pots/" + potNumber);
    }
}