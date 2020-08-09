using UnityEngine;
using UnityEngine.Audio;

public class ButtonFunction : MonoBehaviour {

	public Animator animator;
	public Rigidbody rb;
	//public AudioSource left, right;
	//bool stepLeft, flag;
	//public AudioMixerGroup pitchBendGroup;


	// Use this for initialization
	void Start() {
		animator = GetComponent<Animator>();
		//stepLeft = true;
		//flag = false;
		/*pitchBendGroup =  Resources.Load<AudioMixerGroup>("PitchBender");
		left.outputAudioMixerGroup = pitchBendGroup;
		right.outputAudioMixerGroup = pitchBendGroup;
		left.pitch = 1.5f; 
		right.pitch = 1.5f;
		pitchBendGroup.audioMixer.SetFloat("pitchBend", 1f / 1.5f);*/
	}

	// Update is called once per frame
	void Update() {

		/*if (flag)
		{
			flag = false;
			if (!left.isPlaying)
			{
				stepLeft = false;
				left.Play();
			}
			else if(!right.isPlaying)
			{
				stepLeft = true;
				right.Play();
			}
		}*/

		if (Input.GetKey(KeyCode.W))
		{
			
			if (Input.GetKey(KeyCode.LeftShift))
			{
				if (Input.GetKey(KeyCode.A))
				{
					rb.transform.Rotate(0, -Input.GetAxis("Vertical") * Time.deltaTime * 200, 0);
				}
				if (Input.GetKey(KeyCode.D))
				{
					rb.transform.Rotate(0, Input.GetAxis("Vertical") * Time.deltaTime * 200, 0);
				}
				{
					rb.transform.Translate(0, 0, 5 * Time.deltaTime);
					SprintJump();
				}
			}
			else
			{
				rb.transform.Translate(0, 0, 1 * Time.deltaTime);
				//flag = true;
				Walk();
				
			}

			if (Input.GetKey(KeyCode.A))
			{
				rb.transform.Rotate(0, -Input.GetAxis("Vertical") * Time.deltaTime * 200, 0);
			}
			if (Input.GetKey(KeyCode.D))
			{
				rb.transform.Rotate(0, Input.GetAxis("Vertical") * Time.deltaTime * 200, 0);
			}

			/*if (Input.GetKey(KeyCode.S))
			{
				rb.transform.Rotate(0, 180, 0);
			}*/
		}

		else if (Input.GetKey(KeyCode.S))
		{
			rb.transform.Rotate(0, 180 * Time.deltaTime, 0);
		}

		else Idle();
	}


	public void Idle ()
	{
		animator.SetBool ("Walk", false);
		animator.SetBool ("SprintJump", false);
		animator.SetBool ("SprintSlide", false);
	}

	public void Walk ()
	{
		
		animator.SetBool("Walk", true);
		animator.SetBool ("SprintJump", false);
		animator.SetBool ("SprintSlide", false);
	}

	public void SprintJump()
	{
		animator.SetBool ("Walk", false);
		animator.SetBool ("SprintJump", true);
		animator.SetBool ("SprintSlide", false);
	}

	public void SprintSlide()
	{
		animator.SetBool ("Walk", false);
		animator.SetBool ("SprintJump", false);
		animator.SetBool ("SprintSlide", true);
	}

}
