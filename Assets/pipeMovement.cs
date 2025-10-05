using UnityEngine;

public class pipeMovement : MonoBehaviour
{
    public float movment=5;
    public double deadZone = -42.7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadZone)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);

        }
        transform.position=transform.position+(Vector3.left*movment)*Time.deltaTime;        
    }
}
