using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpostaVita : MonoBehaviour
{

    public GameObject Player;
    public GameObject Enemy;
    public GameObject Proiettile;

    [SerializeField] float vitaPlayer = 5;
    [SerializeField] float vitaEnemy = 5;
    [SerializeField] float Danno = 2;
        
    
    
    
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (vitaPlayer <= 0)
        {
            Destroy(Player);
        }

        if(vitaEnemy <= 0)
        {
            Destroy(Enemy);
        }

        
    }


    
   
        
    

}








