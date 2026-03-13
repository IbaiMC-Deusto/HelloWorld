using UnityEngine;

public class ScaleScript : MonoBehaviour
{ 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scale();
    }

    /// <summary>
    /// Checks the key presses by the player and scales the object.
    /// <para name="Space"> Space -> Forward </para>
    /// <para name = "LeftControl"> LeftControl -> Back </para>
    /// <para name = "RigthArrow"> RightArrow -> Right </para>
    /// <para name = "LeftArrow"> LeftArrow -> Left </para>
    /// <para name = "DownArrow"> DownArrow -> Down </para>
    /// <para name = "UpArrow"> UpArrow -> Up </para>
    /// </summary>
    void Scale()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.localScale += Vector3.forward * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            this.transform.localScale += Vector3.back * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.localScale += Vector3.right * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.localScale += Vector3.left * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.localScale += Vector3.down * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.localScale += Vector3.up * Time.deltaTime;
        }
    }
}
