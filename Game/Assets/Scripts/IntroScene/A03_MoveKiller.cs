using System.Collections;
using UnityEngine;

public class A03_MoveKiller : MonoBehaviour
{
    public AudioSource leftFoot;
    public AudioSource rightFoot;
    bool stepLeft = true;
    GameObject mainChar;
    public GameObject canvas, cam00, mainSeq, preCam_03;
    int stepsTaken;
    bool isWalking, isStanding;
    public AudioSource bgm00, bgmMain, gunShot;
    public ParticleSystem gunShotPS;

    void Start()
    {
        isWalking = false;
        isStanding = false;
        StartCoroutine(StartWalk());
    }

    void Update()
    {
        if (isWalking)
        {
            mainChar.transform.Translate(0, 0, 0.02f * Time.timeScale);
        }
        else if(isStanding)
        {
            mainChar.GetComponent<Animation>().Play("Idle");
        }
    }

    IEnumerator StartWalk()
    {
        yield return new WaitForSeconds(8f);
        mainChar = GameObject.Find("ContractKiller");
        StartCoroutine(WalkSequence());
    }

    IEnumerator WalkSequence()
    {
        // Contract Killer walks up
        isWalking = true;
        while (stepsTaken < 10)
        {
            yield return new WaitForSeconds(0.56f);
            if (stepLeft)
            {
                leftFoot.Play();
                stepLeft = false;
            }
            else
            {

                rightFoot.Play();
                stepLeft = true;
            }

            stepsTaken += 1;
        }

        // Contract Killer stops Walking
        isWalking = false;
        isStanding = true;

        // Wait for dialog exchange
        yield return new WaitForSeconds(16f);
        isStanding = false;
        
        // Gun Shot
        mainChar.GetComponent<Animation>().Play("Fire_1Pistol");
        //yield return new WaitForSeconds(0.16f);
        
        yield return new WaitForSeconds(0.3f);
        gunShotPS.Play();
        yield return new WaitForSeconds(0.1f);
        gunShot.Play();
        bgm00.Stop();

        // ----- Scene Ends ----

        // Next Scene Begins
        canvas.SetActive(true);
        yield return new WaitForSeconds(5f);
        bgmMain.Play();
        mainSeq.SetActive(true);
        cam00.SetActive(true);
        preCam_03.SetActive(false);
    }
}
