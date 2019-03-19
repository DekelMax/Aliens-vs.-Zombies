using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject alienProjectile;

    public List<GameObject> guns = new List<GameObject>();

    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.tag == "gun")
            {
                guns.Add(child.gameObject);
            }
        }
    }

    public void Fire()
    {
        for (int i = 0; i < guns.Count; i++)
        {
            Instantiate(alienProjectile, guns[i].transform.position, transform.rotation);
        }
    }
}
