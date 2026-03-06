using Unity.VisualScripting;
using UnityEngine;

public class ColorMe : MonoBehaviour
{
    public Color color = Color.green;
    private Renderer meshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       meshRenderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.color = color;
    }
}
