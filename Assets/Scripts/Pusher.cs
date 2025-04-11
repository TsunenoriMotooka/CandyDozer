using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    Vector3 startPosition;

    [SerializeField]
    float amplitude;
    [SerializeField]
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        float z = amplitude * Mathf.Sin(Time.time * speed);
        transform.localPosition = startPosition + new Vector3(0, 0, z);        
    }
}

/**
@JAVA
class Hero{
    private String name;
    private int hp;

    public String getName(){
        return this.name;
    }
    public void setName(String name){
        this.name = name;
    }
    public int getHp(){
        return this.hp;
    }
    public void setHp(int hp){
        this.hp = hp;
    }
}

hero.setHp(hero.getHp() + 10)

@C#
class Hero{
    string name;
    int hp;

    public string Name
    {
        get
        {
            return this.name
        }        
        set
        {
            this.name = value;
        }
    }
    public int Hp
    {
        get
        {
            return this.hp;   
        }
        set
        {
            this.hp = hp;
        }
    }
}

hero.Hp += 10


class Hero2{
    public string Name{get;set;}
    public int hp(get;set;)
}


ex)Transform

@JAVA
class Transform{
    private Vector3 position;
    
    public Vector3 getPosition(){
        return this.position;
    }
    public void setPosition(Vector3 position){
        this.position = position   
    }
}

@C#
class Transform{
    Vector3 _position;
    
    public Vector3 position
    {
        get
        {
            return this._position;
        }
        set
        {
            this._position = value;
        }
    }
}

class Tranform{
    public Vector3 position{get;set;}
}

**/
