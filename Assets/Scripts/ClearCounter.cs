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
    }
   }else{
    //there is kitchen object
   }
 }   

 
}
