using System.Collections;
using UnityEngine;

public class A04_preCamSwitch : MonoBehaviour
{
    public GameObject[] cameras;
    //bool started;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.6f;
        StartCoroutine(CamSwitch(0));
    }

    void Update()
    {
    }

    IEnumerator CamSwitch(int i)
    {
        if (i < (cameras.Length - 1))
        {
            //yield return new WaitForSeconds(1f);
            if (i == 0)
                yield return new WaitForSeconds(10f);
            else
                yield return new WaitForSeconds(10f);
            
            cameras[i].SetActive(false);
            cameras[i + 1].SetActive(true);
            StartCoroutine(CamSwitch(i + 1));
        }
        else
        {
            Time.timeScale = 1;
            cameras[i].SetActive(true);
        }
    }
}
