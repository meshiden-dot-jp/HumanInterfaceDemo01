using UnityEngine;

public class TestComponent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3((float)0.6,(float)0.2,(float)0.4) * Time.deltaTime;
    } 
}
