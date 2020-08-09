using UnityEngine;

public class CamControl : MonoBehaviour
{
    private float mouseSensitivityX;
    //private float mouseSensitivityY;
    public Vector3 offset = Vector3.zero;
    public GameObject player;

    private void Start()
    {
        mouseSensitivityX = 100f;
        //mouseSensitivityY = 100f;
        //player = GameObject.Find("ContractKiller");
    }
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(0, -mouseSensitivityX * Time.deltaTime, 0);
        }
        if(Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(0, mouseSensitivityX * Time.deltaTime, 0);
        }

        /*Vector3 targetPosition = player.transform.position;
        transform.position = targetPosition - offset;*/

        /*if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.Rotate(-mouseSensitivityY * Time.deltaTime, 0, 0);
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.Rotate(mouseSensitivityY * Time.deltaTime, 0, 0);
        }*/
    }
}
