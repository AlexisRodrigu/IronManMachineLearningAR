using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] audioClips;
	private string activar = "Activate";
    private Animator animator;

    private static IronMan instance = null;

    // Game Instance Singleton
    public static IronMan Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

    }
    public void Saludo()
    {
        audioSource.clip = audioClips[0];
        audioSource.Play();
        Debug.Log("<color=green><b>" + "Hola" + "</b></color>");
    }
    public void Armar()
    {
        animator.SetBool(activar,true);audioSource.clip = audioClips[1];
        audioSource.Play();
        Debug.Log("<color=red><b>" + "Activaste" + "</b></color>");
    }
}
