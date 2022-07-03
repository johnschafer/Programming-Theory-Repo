using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeTurret : Turret
{

    [SerializeField] GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        ShootingTime = 1f;
        ReloadingTime = 3f;
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
