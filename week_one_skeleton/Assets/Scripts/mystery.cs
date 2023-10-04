using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mystery : MonoBehaviour
{

    // comment on what you think the purpose of this class is; what function does it serve?
    // briefly summarize what each line does 
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.SetParent(this.transform); 
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.SetParent(null); 
        }
    }
}
