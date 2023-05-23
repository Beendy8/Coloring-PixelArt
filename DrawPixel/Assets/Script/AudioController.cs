using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] private GameObject noSound;
    public bool isOn;

    private void Start()
    {
        isOn= true;
    }
    public void OnOffSounds()
    {
        if (!isOn)
        {
            AudioListener.volume = 1f;
            isOn = true;
            noSound.SetActive(false);
        }
        else if (isOn)
        {
            AudioListener.volume = 0f;
            isOn= false;
            noSound.SetActive(true);
        }
    }
}
