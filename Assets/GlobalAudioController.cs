using UnityEngine;
using UnityEngine.InputSystem;

public class GlobalAudioController : MonoBehaviour
{
    private bool muted = false;
    private bool paused = false;

    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        if (keyboard.mKey.wasPressedThisFrame)
        {
            muted = !muted;
            AudioListener.volume = muted ? 0f : 1f;
        }

        if (keyboard.pKey.wasPressedThisFrame)
        {
            paused = !paused;

            AudioSource[] allSources = Object.FindObjectsByType<AudioSource>(
                FindObjectsSortMode.None
            );

            foreach (AudioSource src in allSources)
            {
                if (paused)
                    src.Pause();
                else
                    src.UnPause();
            }
        }
    }
}
