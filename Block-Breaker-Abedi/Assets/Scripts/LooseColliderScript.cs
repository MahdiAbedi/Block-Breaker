using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseColliderScript : MonoBehaviour {

public LevelManager levelmanager;

void OnCollisionEnter2D(Collision2D collision)
    {
        levelmanager = FindObjectOfType<LevelManager>();
        levelmanager.LoadLevel("Loose Screen");
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {

    }
}
