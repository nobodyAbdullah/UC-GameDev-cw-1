using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
       string heroName = "abdullah";
       float heroHeight = 174f;
       int heroAge = 15;
       bool can_hero_fly = true;

       print("Hero Name is " + heroName + " And Hero Age is " + heroAge + " Also Hero Height is " + heroHeight );

       string villianName = "salman";
       int villianAge = 25;
       float villianHeight = 170f;
       bool can_villisn_shoot_webs = true;

       print(villianName + " is " + villianAge + " And His Height is " + villianHeight );

       int ageDifference = 25 - 15;

       print(ageDifference);

       
    }

    // Update is called once per frame
    void Update()
    {
    
  
    }
}
