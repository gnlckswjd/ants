﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerFOV : MonoBehaviour
{

    public PhotonView photonView;
    [SerializeField] private FieldOfView fieldOfView;
    // Start is called before the first frame update
    void Update()
    {
        if(fieldOfView != null)
        {
            if (photonView.IsMine)
            {
                Vector3 targetposition = GetMouseWorldPosition();
                Vector3 aimDir = (targetposition - transform.position).normalized;

                fieldOfView.SetAimDir(aimDir);
                fieldOfView.setOrigin(transform.position);
            }


        }
        else
        {
            if (photonView.IsMine)
                fieldOfView = GameObject.FindWithTag("FOV").GetComponent<FieldOfView>();
        }
    }

    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
}
