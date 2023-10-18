using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound {

	public string name; //The name of the sound

	public AudioClip clip; //stores file in component

	[Range(0f, 1f)]
	public float volume = .75f;
	[Range(0f, 1f)]
	public float volumeVariance = .1f;
	//volume settings to adjust
	[Range(.1f, 3f)]
	public float pitch = 1f;
	[Range(0f, 1f)]
	public float pitchVariance = .1f;
	//pitch settings to adjust
	public bool loop = false;
	//bool for loop
	public AudioMixerGroup mixerGroup;
	//If you have audio mixer, assign here
	[HideInInspector]
	public AudioSource source;

}
