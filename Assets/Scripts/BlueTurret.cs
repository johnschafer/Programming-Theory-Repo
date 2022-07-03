using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTurret : Turret // Inheritance
{
    [SerializeField] private GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        ShootingTime = 1.5f;
        ReloadingTime = 1.0f;
    }

    protected override IEnumerator Shooting()
    {
        throw new System.NotImplementedException();
    }

    protected override IEnumerator Reloading()
    {
        throw new System.NotImplementedException();
    }
}
