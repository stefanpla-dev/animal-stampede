using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -15) {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 15) {
            transform.position = new Vector3(15, transform.position.y,transform.position.z);
        }
    }
}
