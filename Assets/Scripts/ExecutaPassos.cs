using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutaPassos : MonoBehaviour {

    [SerializeField] private AudioClip[] grass_steps;
    [SerializeField] private AudioSource step_source;
    private int aux_step = 1;

    public void PlayStep() {
        step_source.Play();
        aux_step = (aux_step + 1) % 2;
    }

    public void PlayGrassStep() {
        step_source.clip = grass_steps[aux_step];
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
