using UnityEngine;

public class PositionTracker : MonoBehaviour
{

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TracePosition();
    }

    /// <summary>
    ///  Prints the object position when the <b> Space </b> key is pressed. 
    /// </summary>
    void TracePosition()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float positionX = this.transform.position.x;
            float positionY = this.transform.position.y;
            float positionZ = this.transform.position.z;

            print(string.Format("My position is: X = {0}, Y = {1}, Z = {2}", positionX, positionY, positionZ));
        }
    }
}
