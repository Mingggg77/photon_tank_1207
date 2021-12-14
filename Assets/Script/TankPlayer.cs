using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


namespace Tanks
{
    public class TankPlayer : MonoBehaviourPunCallbacks
    {
        // Reference to tank's movement script, used to disable and enable control.
        private Complete.TankMovement m_Movement;
        // Reference to tank's shooting script, used to disable and enable control.
        private Complete.TankShooting m_Shooting;
        private void Awake()
        {
            m_Movement = GetComponent<Complete.TankMovement>();
            m_Shooting = GetComponent<Complete.TankShooting>();
            if (!photonView.IsMine)
            {
                m_Movement.enabled = false;
                m_Shooting.enabled = false;
                enabled = false;
            }
        }
    }
}

