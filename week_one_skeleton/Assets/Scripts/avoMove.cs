using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class avoMove : MonoBehaviour
{

    public TextMeshProUGUI countText;
    public int count;
    public Sprite teen;
    public Sprite elder;
    public Sprite final;

    public bar healthBar;
    public float maxHealth;
    public float currHealth;
    public float hps; //amt of health loss per sec
    public float hpj; //amout of health gained per jump 

    [SerializeField] Rigidbody2D avo;//4 our bb cado
    [SerializeField] float speed;  //cado zoom rate
    [SerializeField] float jump;

    private float direction;

    private void Start()
    {
        countText.text = count.ToString();
        currHealth = maxHealth;
        healthBar.reset(maxHealth);
    }

    // Start is called before the first frame update
    public void OnMouseDown() //speical unity func 
    {
        if (count > 0)
        {
            count -= 1;
            countText.text = count.ToString();
            if (count == 20)
            {
                this.GetComponent<SpriteRenderer>().sprite = teen; 
            } else if (count == 10)
            {
                this.GetComponent<SpriteRenderer>().sprite = elder; 
            } else if (count == 0)
            {
                countText.text = "final avo!";
                this.gameObject.GetComponent<SpriteRenderer>().sprite = final;
            }
        } 
       
    }
    // Update is called once per frame
    void Update()
    {
       direction = Input.GetAxisRaw("Horizontal");//press left -1, press right 1

        if (Input.GetButtonDown("Jump"))
        {
            avo.velocity = new Vector2(avo.velocity.x, jump);
            if (currHealth < maxHealth)
            {
                currHealth += hpj;
                healthBar.setValue(currHealth);
            }
 
        } else
        {
            if (currHealth >= hps)
            {
                currHealth -= Time.deltaTime * hps;
                healthBar.setValue(currHealth);
            }
        }
                                           
    }

    //for special physics shit 
    void FixedUpdate()
    {
        avo.velocity = new Vector2(direction * speed, avo.velocity.y); 
    }
}
