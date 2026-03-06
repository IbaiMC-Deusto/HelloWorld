using System;
using Unity.VisualScripting;
using UnityEngine;

public class ColorWorld : MonoBehaviour
{
    public MeshRenderer[] allTheGameObjects;
    public GameObject[] allGameObjectsWithTag;
    public Color color;
    public Boolean FindByTag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    void Start()
    {
        allTheGameObjects = FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None);
        allGameObjectsWithTag = GameObject.FindGameObjectsWithTag("Rojo");
    }

    // Update is called once per frame
    void Update()
    {

        if (FindByTag)
        {
            foreach (GameObject o in allGameObjectsWithTag)
            {
                o.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        } else
        {
            foreach (MeshRenderer o in allTheGameObjects)
            {
                o.material.color = color;
            }
        }
    }
    
}
