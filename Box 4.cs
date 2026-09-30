using JetBrains.Annotations;
using UnityEngine;

public class Box4 : MonoBehaviour
{
    public float speed =0.2f;
    public float rotateX = 0.5f;
    public float rotateY = 0.5f;
    public float upanddown = 0.5f;
    public float upanddownspeed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(1 * Time.deltaTime, 0, 0);
        }
    }
}
