using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySwitch : MonoBehaviour
{
    //Animator of Interactive object
    Animator interactiveAnimator;

    //UI Legend to be turned off or on when getting close to Interactive
    public GameObject displayPrompt;
    public GameObject objectAffected;
    //When the player stays within the range...
   
   bool isActive;
   
   
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
             //Turn Legend to true
            displayPrompt.gameObject.SetActive(true);

            //Take Animator from the interactive...
            interactiveAnimator = objectAffected.GetComponent<Animator>();

            if (interactiveAnimator && Input.GetKey(KeyCode.Return))
            {

            //Turn animation on in Interactive
            interactiveAnimator.SetBool("isActive", true);
            }

        }  

         if (interactiveAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Active") && Input.GetKey(KeyCode.Return)){ 

            interactiveAnimator.SetBool("isActive", false);
            
         } 


    }

    //when you walk away
    private void OnTriggerExit(Collider other)
    {
    //turn off legend
    displayPrompt.gameObject.SetActive(false);
    }

}
