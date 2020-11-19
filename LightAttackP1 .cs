using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightAttackP1 : MonoBehaviour
{

  

    public Collider L;
    

    public int maxHealth = 100;
    public int currentHealth;

    public healthbar healthbar;



    // Start is called before the first frame update
    void Start()
    {

        //set jab

        L = GetComponent<Collider>();
        
       



        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);


    }




    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Joystick1Button2))

        {
            //get the box collider 

            L.enabled = !L.enabled;



            print("Joystick1Button2 pressed");
        }

       

        
    }

    private void OnTriggerEnter(Collider other)
    {

        void TakeDamage(int damage)
        {
            currentHealth -= damage;

            healthbar.SetHealth(currentHealth);
        }

        if (other.gameObject.tag == "Player")
        {

            TakeDamage(45000);
   
            print("take damage");

        }
       
        if (other.gameObject.tag == "Player")
        {
            if (currentHealth <= 0)
                
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }


        

    }



   

}
