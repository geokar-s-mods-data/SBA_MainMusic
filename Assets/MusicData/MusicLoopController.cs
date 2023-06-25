using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoopController : MonoBehaviour
{
	private AudioSource _source;
	public AudioClip introClip;
	public int bpm = 120;
	public int introBeatOffset = 0;
}
