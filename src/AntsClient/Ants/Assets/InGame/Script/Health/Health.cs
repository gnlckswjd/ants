﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
public class Health : MonoBehaviour
{
    public float HP;
    EnemyStun enemyStun;
    public Animator ani;
    Brain brain;
    private void Start()
    {
        brain = GetComponent<Brain>();
        enemyStun = GetComponent<EnemyStun>();
        ani = GetComponent<Animator>();
    }
    private void Update()
    {
        if (HP <= 0)
        {
            Destroy(this.gameObject);
            if(this.tag == "Player")
            {
                PhotonNetwork.Disconnect();
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    public void Hit(float damage, float time)
    {
        HP -= damage;
        ani.SetBool("hit", true);
        if(this.tag == "Enemy" && enemyStun != null)
        {
            enemyStun.Stun(time);
        }
        else
        {
            if(brain != null && brain.isAttacked == false)
            {
                brain.isAttacked = true;
                brain.StopAllCoroutines();
                brain.StartEvaluateCoroutine();
                
            }
        }

    }
    public void endHitAnimation()
    {
        ani.SetBool("hit", false);
    }
}
