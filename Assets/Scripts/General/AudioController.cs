using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource1;
    [SerializeField] AudioClip song1;

    void Start() => audioSource1.PlayOneShot(song1);
}
