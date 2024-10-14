using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject[] gameObjList;

    private void SetColor(Transform transform, Color color)
    {
        transform.GetComponent<Renderer>().material.color = color;
    }

    public void changeColor(string[] values)
    {
        var shapeVar = values[1];
        var colorVar = values[0];

        if (ColorUtility.TryParseHtmlString(colorVar, out var color))
        {
            if (!string.IsNullOrEmpty(shapeVar))
            {
                var shape = transform.Find(shapeVar);
                if (shape) SetColor(shape, color);
            }
            else
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    SetColor(transform.GetChild(i), color);
                }
            }
        }
    }
}
