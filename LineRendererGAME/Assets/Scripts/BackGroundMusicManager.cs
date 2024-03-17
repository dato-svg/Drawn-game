using System;
using UnityEngine;

public class BackGroundMusicManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] _audioClips;

    [SerializeField] private AudioSource _audioSource;
    public static BackGroundMusicManager _instance;
    private int _currentIndex;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
           
            Destroy(gameObject);
        }

       
    }
    
    private void Update()
    {
        if (!_audioSource.isPlaying)
        {
            PlayNextClip();
        }
    }
    
    private void PlayNextClip()
    {
        if (_audioClips.Length > 0)
        {
            _audioSource.clip = _audioClips[_currentIndex]; 
            _audioSource.Play();
            _currentIndex = (_currentIndex + 1) % _audioClips.Length; 
        }
        else
        {
            Debug.LogWarning("No audio clips assigned to BackGroundMusicManager.");
        }
    }
    
}
