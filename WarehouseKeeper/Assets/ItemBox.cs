using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer MyRenderer;
    [SerializeField] Color touchColor;
    private Color OriginColor;
    void Start()
    {
        MyRenderer = GetComponent<Renderer>();
        OriginColor = MyRenderer.material.color;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            MyRenderer.material.color = touchColor;
            Level.iLevel.boxNum--;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            MyRenderer.material.color = OriginColor;
            Level.iLevel.boxNum++;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            MyRenderer.material.color = touchColor;
        }
    }
}