using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{ //最大HPと現在のHP。
    int maxHp = 155;
    int currentHp;
    //Sliderを入れる
    public Slider slider;
    // Start is called before the first frame update

     int damage = 1;
     int heal = 1;
    void Start()
    {
          //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }

    // Update is called once per frame
    void Update()
    {
if(Input.GetKey(KeyCode.D)) { //damegeを受けた際
    currentHp = currentHp - damage;
            Debug.Log("After currentHp (damage): " + currentHp);

            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            if(currentHp < 0){currentHp = 0;}
            slider.value = (float)currentHp / (float)maxHp; ;
            Debug.Log("slider.value (damage): " + slider.value);
	}

    if(Input.GetKey(KeyCode.H)) { //healを受けた際
        currentHp = currentHp + heal;
            Debug.Log("After currentHp (heal): " + currentHp);
            if(currentHp > maxHp){currentHp = maxHp;}
            slider.value = (float)currentHp / (float)maxHp; ;
            Debug.Log("slider.value (heal): " + slider.value);


    }
         
    }
}
