using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MediumAttackP1 : MonoBehaviour
{
    public Collider M;


    public int maxHealth = 1000000;
    public int currentHealth;

    public healthbar healthbar;



    // Start is called before the first frame update
    void Start()
    {

        //set jab


        M = GetComponent<Collider>();




        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);


    }




    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Joystick1Button3))

        {
            //get the box collider 

            M.enabled = !M.enabled;



            print("Joystick1Button3 pressed");



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

            TakeDamage(55000);

            print("take damage");

        }

        if (other.gameObject.tag == "Player")
        {
            if (currentHealth <= 0)

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }




    }








}