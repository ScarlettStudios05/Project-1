using UnityEngine;

public class Box1 : MonoBehaviour
{
    public float speed = 50f;
    public float rotateX = 100f;
    public float rotateY = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX * Time.deltaTime, rotateY * Time.deltaTime, 0);
    }
}
