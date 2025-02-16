using UnityEngine;

public class ClearCounter : BaseCounter
{

 [SerializeField] private KitchenObjectSO kitchenObjectSO;  


public override void Interact(Player player){
   if(!HasKitchenObject()){
    //there is no kitchen object here
    if(player.HasKitchenObject()){
        //player is carraying something
        player.GetKitchenObject().SetKitchenObjectParent(this);
    }else{
      // player not carrying any 
    }
   }else{
    //there is kitchen object
    if (player.HasKitchenObject()){
      // player is carrying  something
    }else{
      // player is not carrying anything
      GetKitchenObject().SetKitchenObjectParent(player);
    }
   }
 } 
}
