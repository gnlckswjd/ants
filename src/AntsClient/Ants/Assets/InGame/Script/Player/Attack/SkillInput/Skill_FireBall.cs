﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Skill_FireBall : MonoBehaviour
{
    public PhotonView photonView;
    public GameObject bullet;
    public Transform pos;
    public float _cooltime = 1;
    public float _curtime = 0;


    // Update is called once per frame
    void Update()
    {
        Vector2 len = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float z = Mathf.Atan2(len.y, len.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, z);
        _curtime -= Time.deltaTime;
        if (_curtime <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Q) && photonView.IsMine)
            {
                PhotonNetwork.Instantiate(bullet.name, new Vector3(pos.transform.position.x, pos.transform.position.y, -1), transform.rotation);
                PhotonNetwork.Instantiate(bullet.name, new Vector3(pos.transform.position.x, pos.transform.position.y, -1), Quaternion.Euler(0, 0, z + 30));
                PhotonNetwork.Instantiate(bullet.name, new Vector3(pos.transform.position.x, pos.transform.position.y, -1), Quaternion.Euler(0, 0, z - 30));

                _curtime = _cooltime;
            }

        }

    }
}
