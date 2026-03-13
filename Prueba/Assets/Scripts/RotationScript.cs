using NUnit.Framework.Constraints;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
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
    void Rotation()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.rotation *= Quaternion.Euler(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.rotation *= Quaternion.Euler(Vector3.back);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation *= Quaternion.Euler(Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation *= Quaternion.Euler(Vector3.left);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.rotation *= Quaternion.Euler(Vector3.down);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.rotation *= Quaternion.Euler(Vector3.up);
        }
    }
}
