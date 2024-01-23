using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public Vector3 screenPoint;

    Vector3 offset;
    public Camera cam;
    public DragRange gizmoRange;

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        screenPoint = cam.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    private void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = cam.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }
}
