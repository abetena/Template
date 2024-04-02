using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepActivate : MonoBehaviour
{
    //Animator of Interactive object
    Animator interactiveAnimator;

    //UI Legend to be turned off or on when getting close to Interactive
    public GameObject objectAffected;
    //When the player stays within the range...
   
   bool isActive;
   
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
        

            //Take Animator from the interactive...
            interactiveAnimator = objectAffected.GetComponent<Animator>();

            //Turn animation on in Interactive
            interactiveAnimator.SetBool("isActive", true);
            }

        }  

    

}
