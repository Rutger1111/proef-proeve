using Unity.VisualScripting;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    float Timer = 1;
    public float speed = 1;
    public ICommand chooseCommand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update(){
        Timer -= Time.deltaTime;
        if(Timer - Time.deltaTime * speed <= 0){
            Timer = 1;
            chooseCommand.Invoke();
        }
    }
    
}
