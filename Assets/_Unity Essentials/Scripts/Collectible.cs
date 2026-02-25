using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
}
