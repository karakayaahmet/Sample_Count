using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Surukle : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    private void OnMouseDown()
    {
        // Fare d��mesine t�kland���nda nesnenin ekran konumunu kaydedin.
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseDrag()
    {
        // Fare s�r�klendi�inde nesneyi g�ncel konuma ta��y�n.
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}