using UnityEngine; 

public class updateLove : MonoBehaviour
{

    public float maxLove;
    public float currLove;
    public bar loveBar;
    public float lpc;  //love per click
    public float lps;  //love loss per second 

    private void Start()
    {
        currLove = maxLove;
        loveBar.reset(maxLove); 
    }

    public void Update()
    {
        if (currLove >= lps)
        {
            currLove =  currLove - lps*Time.deltaTime;
            loveBar.setValue(currLove);

        }
    }

    public void UpdateLove()
    {
        if (currLove < maxLove)
        {
            currLove = currLove + lpc;
            loveBar.setValue(currLove);
        }
    }
}
