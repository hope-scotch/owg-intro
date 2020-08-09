using System.Collections;
using UnityEngine;

public class A02_MoveChar : MonoBehaviour
{
    public AudioSource leftFoot;
    public AudioSource rightFoot;
    
    public GameObject mainChar;
    Animator animator;

    int stepsTaken;
    bool stepLeft;

    void Start()
    {
        stepLeft = true;
        stepsTaken = 0;
        StartCoroutine(StartWalk());
        Time.timeScale = 0.8f;
    }

    void Update()
    {
        /*if(mainChar != null)
        {
            Walk();
        }*/
    }

    public void Walk()
    {
        animator = mainChar.GetComponent<Animator>();
        animator.SetBool("Walk", true);
        animator.SetBool("SprintJump", false);
        animator.SetBool("SprintSlide", false);
    }

    IEnumerator StartWalk()
    {
        yield return new WaitForSeconds(19f);
        mainChar.SetActive(true); 
        Walk();
        StartCoroutine(WalkSequence());
    }

    IEnumerator WalkSequence()
    {

        while(stepsTaken < 10)
        {
            yield return new WaitForSeconds(0.56f);

            if(stepLeft)
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

        Destroy(mainChar);
    }
}
