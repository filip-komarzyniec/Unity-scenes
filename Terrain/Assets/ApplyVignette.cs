using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ApplyVignette : MonoBehaviour {
    PostProcessVolume m_Volume;
    Vignette m_Vignette;
    Bloom m_Bloom;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        m_Volume = gameObject.GetComponent<PostProcessVolume>();
        m_Volume.profile.TryGetSettings(out m_Vignette);
        m_Volume.profile.TryGetSettings(out m_Bloom);
    
    }

    void Update() {    
        turnEffectsOn();
    }

    void turnEffectsOn() {
        if (player.transform.position.y <= 1) {
            m_Vignette.enabled.value = true;
            m_Bloom.enabled.value = true;
        }
    }
}
