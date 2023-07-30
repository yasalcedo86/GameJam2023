using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScript : MonoBehaviour
{
    public void ChangePoints(int points)
    {
        gameObject.GetComponent<Text>().text = points.ToString();
    }
}
