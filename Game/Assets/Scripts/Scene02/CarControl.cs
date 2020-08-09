using UnityEngine;

public class CarControl : MonoBehaviour
{
    public Rigidbody car;
    float speed, sensitivity;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 1000;
        sensitivity = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            car.velocity = new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            car.velocity = new Vector3(sensitivity * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            car.velocity = new Vector3(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            car.velocity = new Vector3(-sensitivity * Time.deltaTime, 0, 0);
        }
    }
}
