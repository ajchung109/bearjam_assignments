using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class avoMove : MonoBehaviour
{

    public TextMeshProUGUI countText;
    public int count;

    [SerializeField] Rigidbody2D avo;//4 our bb cado
    [SerializeField] float speed;  //cado zoom rate
    [SerializeField] float jump;

    private float direction;

    private void Start()
    {
        countText.text = count.ToString();
    }

    // Start is called before the first frame update
    public void OnMouseDown() //speical unity func 
    {

        return; 
       
    }
    // Update is called once per frame
    void Update()
    {
        return; 
                                           
    }

    //for special physics updates 
    void FixedUpdate()
    {
        return;  
    }
}
