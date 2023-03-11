using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Character")
        {
            Pickup(trigger);            
        }
    }

    void Pickup(Collider2D character)
    {
        CharacterBehaviors charBehav = character.GetComponent<CharacterBehaviors>();
        charBehav.canShoot = true;
        Destroy(gameObject);
    }
}
