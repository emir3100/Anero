using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class TypeWriterEffect : MonoBehaviour {

	public float Delay = 0.025f;
	public bool TextStarted;

	private string fullText;
	private string currentText = "";
	public AudioClip Voice;
	[HideInInspector]public AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = Voice;
	}

	public void StartText(string text) 
	{
		TextStarted = true;
		fullText = text;
		StartCoroutine(ShowText());
	}

    IEnumerator ShowText(){
		audioSource.Play();
		for(int i = 0; i <= fullText.Length; i++){
			currentText = fullText.Substring(0,i);
			this.GetComponent<TextMeshProUGUI>().text = currentText;
			yield return new WaitForSeconds(Delay);

			if(i >= fullText.Length)
            {
                audioSource.Stop();
				TextStarted = false;
			}
		}
	}
}
