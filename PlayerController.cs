using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 15.0f;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        // Keep Player within bounds
        if (transform.position.x < -xRange)
        {
            WithinBoundsLeft();
        }
        if (transform.position.x > xRange)
        {
            WithinBoundsRight();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch projectile from the player.
            Fire();
        }
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    void WithinBoundsRight() 
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    void WithinBoundsLeft()
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }

    void Fire()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
