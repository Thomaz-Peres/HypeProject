using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;


    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;

    public List<Vector2> positions;

    public Material corAtual;

    void Start()
    {
        corAtual = linePrefab.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

        }


        if(Input.GetMouseButtonDown(0))
        {
            CreateLine();
        }

        if(Input.GetMouseButton(0))
        {
            Vector2 drawingPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(Vector2.Distance(drawingPosition, positions[positions.Count -1] ) >.1f)
            {
                UpdateLine(drawingPosition);
            }
        }
    }

    private void CreateLine()
    {
        // Create a line (position is set by Line Renderer component)
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        
        positions.Clear();        

        positions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        positions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));

                
        lineRenderer.SetPosition(0, positions[0]);
        lineRenderer.SetPosition(1, positions[1]);
        
        edgeCollider.points = positions.ToArray();
    }

    private void UpdateLine(Vector2 drawingPosition)
    {
        positions.Add(drawingPosition);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, drawingPosition);

     
        edgeCollider.points = positions.ToArray();
    }
}
