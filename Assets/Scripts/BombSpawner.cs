using System;
using System.Collections;
using UnityEngine;
using Fusion;
using UnityEngine.InputSystem;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the "scoreText" field of the new laser.
 */
public class LaserShooter: ClickSpawner  {
    [SerializeField] NumberField scoreField;
    [SerializeField] InputAction attackLocation;


    protected override GameObject spawnObject() {


        GameObject newObject = base.spawnObject();  // base = super
        Mover mover = newObject.GetComponent<Mover>();
        attackLocation = new InputAction(type: InputActionType.Value, expectedControlType: "Vector2");
        attackLocation.AddBinding("<Mouse>/position");
        Vector2 attackLocationInScreenCoordinates = attackLocation.ReadValue<Vector2>();

        //mover.SetVelocity(attackLocationInScreenCoordinates) ;

        // Modify the text field of the new object.
        if (HasStateAuthority)
        {
        
    
            return newObject;
        }
        return null;
      
    }

}