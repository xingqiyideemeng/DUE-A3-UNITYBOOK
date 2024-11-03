using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeAudio : MonoBehaviour
{
    public AudioSource source;
    private bool isPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        isPlayer = !isPlayer;
        if (isPlayer) source.Play();
        else source.Pause();
    }
}
