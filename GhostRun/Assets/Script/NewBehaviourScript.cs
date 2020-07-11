using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject zombie;
    public Transform zombieTran;
    public Camera cam;
    public ParticleSystem ps;
    private void Start()
    {
        print(zombie.tag);
        print(zombie.layer);
        zombieTran.position = new Vector3(-7, 0, 0);

    }
    private void Update()
    {
        zombieTran.Translate(0, 0, 1);
    }
}
