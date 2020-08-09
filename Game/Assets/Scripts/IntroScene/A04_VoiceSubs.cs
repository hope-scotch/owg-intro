using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class A04_VoiceSubs : MonoBehaviour
{
    public GameObject subText;
    public AudioSource[] voiceOver;

    void Start()
    {
        Time.timeScale = 0.8f;
        StartCoroutine(subs());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator subs()
    {
        yield return new WaitForSeconds(14f);
        subText.GetComponent<Text>().text = "Here you are, the last one";

        voiceOver[0].Play();
        if(voiceOver[0].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false);
        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "";


        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "Wha- What?";
        
        voiceOver[1].Play();

        if (voiceOver[1].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false); 
        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "";


        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "Your family was a good riddance";
        
        voiceOver[2].Play();

        if (voiceOver[2].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false);
        yield return new WaitForSeconds(1f); 
        subText.GetComponent<Text>().text = "";

        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "You killed them?";
        
        voiceOver[3].Play();

        if (voiceOver[3].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false);
        yield return new WaitForSeconds(1f); 
        subText.GetComponent<Text>().text = "";

        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "Yeah. And now it's your turn";
        
        voiceOver[4].Play();

        if (voiceOver[4].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false);
        yield return new WaitForSeconds(1f); 
        subText.GetComponent<Text>().text = "";


        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "But.. What have I done?";
        
        voiceOver[5].Play();

        if (voiceOver[5].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false);
        yield return new WaitForSeconds(1f); 
        subText.GetComponent<Text>().text = "";

        yield return new WaitForSeconds(1f);
        subText.GetComponent<Text>().text = "Nothing. I just don't want anyone going up against me";
        
        voiceOver[6].Play();

        if (voiceOver[6].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false);
        yield return new WaitForSeconds(1f); 
        subText.GetComponent<Text>().text = ""; 
        
        yield return new WaitForSeconds(2f);
        subText.GetComponent<Text>().text = "Wait wait please please please don't";
        
        voiceOver[7].Play();

        if (voiceOver[7].isPlaying)
            subText.SetActive(true);
        else
            subText.SetActive(false);
        yield return new WaitForSeconds(1f); 
        subText.GetComponent<Text>().text = "";
    }
}
