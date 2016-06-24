using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
    public GameObject explosion;

    public GameObject decallExplosion;
    GameObject parentfater;
    string parentname;
  

    public void parent(GameObject newParent, GameObject newChildren)
    {
        //Makes the GameObject "newParent" the parent of the GameObject "player".
        newChildren.transform.parent = newParent.transform;

        //Display the parent's name in the console.
       // Debug.Log("Player's Parent: " + newChildren.transform.parent.name);

        // Check if the new parent has a parent GameObject.
        if (newParent.transform.parent != null)
        {
            //Display the name of the grand parent of the player.
         //   Debug.Log("Player's Grand parent: " + newChildren.transform.parent.parent.name);
        }
    }

    void OnCollisionEnter(Collision bulletCollisiont){
		Destroy(Instantiate (explosion,
			bulletCollisiont.contacts [0].point,
			Quaternion.identity), 2f);
		Destroy (this.gameObject);
        
        //Rigidbody children;
        GameObject childrenDecall = Instantiate(decallExplosion,
            bulletCollisiont.contacts[0].point,
            Quaternion.FromToRotation(bulletCollisiont.contacts[0].point, Vector3.forward)) as GameObject;

        //Parent

        parentfater = bulletCollisiont.gameObject;
        //parentname = parentfater.name;
        //Debug.Log("parent name:" + parentname);
        parent(parentfater , childrenDecall);
    }

}
