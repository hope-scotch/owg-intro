using System.Collections;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject[] cameras;
    public GameObject[] credLeadDes;
    public AudioSource bgm;
    bool isStart;
    //bool started;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.6f;
        StartCoroutine(CamSwitch(0));
        isStart = false;
    }

    void Update()
    {
        if (isStart)
        {
            bgm.volume -= 0.005f;
        }
    }

    IEnumerator CamSwitch(int i)
    {
        if (i < (cameras.Length - 1))
        {

            //yield return new WaitForSeconds(1f);
            
            if (i == 0)
                yield return new WaitForSeconds(2.1f);
            else
                yield return new WaitForSeconds(5.9f);
            credLeadDes[i].SetActive(false);
            credLeadDes[i + 1].SetActive(true);
            cameras[i].SetActive(false);
            cameras[i + 1].SetActive(true);
            StartCoroutine(CamSwitch(i + 1));
        }
        else
        {
            //bgm.Stop();
            isStart = true;
            Time.timeScale = 1;
            cameras[i].SetActive(true);
            yield return new WaitForSeconds(5.9f);
            credLeadDes[i].SetActive(false);
        }
    }

}
