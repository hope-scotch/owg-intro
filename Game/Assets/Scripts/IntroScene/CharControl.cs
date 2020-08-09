using UnityEngine;

public class CharControl : MonoBehaviour
{
    public GameObject player;
    private bool isWalking, isRunning;
    private float horizontalMove;
    private float verticalMove;

    private void Start()
    {
        //player = GameObject.Find("ContractKiller");
        isWalking = false;
        isRunning = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {

                player.GetComponent<Animation>().Play("Run");
                horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 200;
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 5;
                isRunning = true;
                transform.Rotate(0, horizontalMove, 0);
                transform.Translate(0, 0, verticalMove);
            }
            else
            {
                player.GetComponent<Animation>().Play("Walk");
                horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 200;
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 1;
                isWalking = true;
                transform.Rotate(0, horizontalMove, 0);
                transform.Translate(0, 0, verticalMove);
            }
        }

        else
        {
            player.GetComponent<Animation>().Play("Idle");
            isRunning = false;
            isWalking = false;
        }
    }
}
