﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour {

    const float locomotionAnimationSmoothTime = 0.1f;

    private NavMeshAgent agent;
    private Animator animator;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float speed_percent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speed_percent, locomotionAnimationSmoothTime, Time.deltaTime);
	}
}
