using System;
using UnityEngine;

public class R_Player : MonoBehaviour
{
    public PlayerDataExarch playerData;

    private void Start()
    {
        Debug.Log(playerData.name);
    }
}
