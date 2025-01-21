using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private float _CoinSpeed = 3.5f;
    public GameObject OnCollisionEffect;  
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _CoinSpeed, 0);

    }
    
    private void  OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player")){
        //Destroy The Coin
        Destroy(gameObject);    
        
        //Instantiate the effect
        Instantiate(OnCollisionEffect, transform.position , transform.rotation);
        
       
        
        }
        
    }
    
    
    
}
