using UnityEngine;
using System.Collections;
 
public class PaddleScript : MonoBehaviour {
 
   [SerializeField]
   bool isPlayerTwo;
   [SerializeField]
   float speed = 0.2f;       // how far the paddle moves per frame
   Transform myTransform;    // reference to the object's transform
 
   // Use this for initialization
   void Start () {
       myTransform = transform;
   }
     
   // FixedUpdate is called once per physics tick/frame
   void FixedUpdate () {
       // first decide if this is player 1 or player 2 so we know what keys to listen for
       if (isPlayerTwo)
       {
           if (Input.GetKey ("o"))
               MoveUp ();
           else if (Input.GetKey ("l"))
               MoveDown ();
       }
       else // if not player 2 it must be player 1
       {
           if (Input.GetKey ("q"))
               MoveUp ();
           else if (Input.GetKey ("a"))
               MoveDown ();
       }
    }
 
   // move the player's paddle up by an amount determined by 'speed'
   void MoveUp()
   {
       myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y + speed);
   }
 
   // move the player's paddle down by an amount determined by 'speed'
   void MoveDown()
   {
       myTransform.position = new Vector2 (myTransform.position.x, myTransform.position.y - speed);            
   }
}