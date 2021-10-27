using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Color mudarDeCor;

    Line line;

    public void Start()
    {
        line = GetComponent<Line>();
    }

    public void ChangeBlue()
    {
        line.lineRenderer.material.color = new Color(mudarDeCor.r, mudarDeCor.g, mudarDeCor.b);
        line.lineRenderer.name = "blueLine";
    }
}
