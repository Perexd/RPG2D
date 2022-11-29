using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startpoint : MonoBehaviour
{
    public string uuid;
    private playercontroler player;
    [SerializeField] private Vector2 facingDirection;
    // Start is called before the first frame update
    void Start()
    { 
        player = FindObjectOfType<playercontroler>();
        if (!player.nextUuid.Equals(uuid))
        {
            return;
        }
        player.transform.position = transform.position;
        player.lasDirection = facingDirection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
