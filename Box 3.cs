using UnityEngine;
using UnityEngine.Rendering;

public class Box3 : MonoBehaviour
{
    public float speed = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(2, 0, 0);
        }

    }
}
