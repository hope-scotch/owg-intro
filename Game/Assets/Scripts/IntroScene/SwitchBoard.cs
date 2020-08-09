using UnityEngine;

public class SwitchBoard : MonoBehaviour
{
    public GameObject[] lights;


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (lights[0] != null)
            {
                lights[0].SetActive(!lights[0].activeSelf);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (lights[1] != null)
            {
                lights[1].SetActive(!lights[1].activeSelf);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (lights[2] != null)
            {
                lights[2].SetActive(!lights[2].activeSelf);
            }
        }

    }
}
