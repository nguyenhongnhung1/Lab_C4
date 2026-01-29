using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleAudioController : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            audioSource.Play();
        }

        if (keyboard.sKey.wasPressedThisFrame)
        {
            audioSource.Stop();
        }
    }
}
