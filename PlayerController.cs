using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = horizontalInput.GetAxis("Horizontal");
    }
}
