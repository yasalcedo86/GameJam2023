using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsScript : MonoBehaviour
{
    private int pts = 0;
    public TextMeshProUGUI pointsGameObject;
    public void ChangePoints(int points)
    {
        pts = points;
        pointsGameObject.text = points.ToString();
    }

    public void AddPoints(int points)
    {
        pts += points;
        ChangePoints(pts);
    }
}
