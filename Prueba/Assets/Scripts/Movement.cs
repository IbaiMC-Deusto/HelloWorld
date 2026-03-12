using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Momevent();
    }

    /// <summary>
    /// If <b> space </b> key is pressed, the object moves forward
    /// </summary>
    void Momevent()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.position += Vector3.forward * Time.deltaTime;
        }
    }
}
